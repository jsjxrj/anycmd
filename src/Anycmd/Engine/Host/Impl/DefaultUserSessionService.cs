﻿
namespace Anycmd.Engine.Host.Impl
{
    using Ac;
    using Engine.Ac;
    using Repositories;
    using System;

    public class DefaultUserSessionService : IUserSessionService
    {
        #region CreateSession

        /// <summary>
        /// 创建Ac会话
        /// </summary>
        /// <param name="account"></param>
        /// <param name="host"></param>
        /// <param name="sessionId">会话标识。会话级的权限依赖于会话的持久跟踪</param>
        /// <returns></returns>
        public IUserSession CreateSession(IAcDomain host, Guid sessionId, AccountState account)
        {
            var userSessionRepository = host.GetRequiredService<IRepository<UserSession>>();
            var identity = new AnycmdIdentity("Anycmd", true, account.LoginName);
            var principal = new AnycmdPrincipal(host, identity);
            IUserSession user = new UserSessionState(host, sessionId, principal, account);
            var userSessionEntity = new UserSession
            {
                Id = sessionId,
                AccountId = account.Id,
                AuthenticationType = identity.AuthenticationType,
                Description = null,
                IsAuthenticated = identity.IsAuthenticated,
                IsEnabled = 1,
                LoginName = account.LoginName
            };
            userSessionRepository.Add(userSessionEntity);
            userSessionRepository.Context.Commit();
            return user;
        }
        #endregion

        #region DeleteSession

        /// <summary>
        /// 删除会话
        /// <remarks>
        /// 会话不应该经常删除，会话级的权限依赖于会话的持久跟踪。用户退出系统只需要清空该用户的内存会话记录和更新数据库中的会话记录为IsAuthenticated为false而不需要删除持久的UserSession。
        /// </remarks>
        /// </summary>
        /// <param name="host"></param>
        /// <param name="sessionId"></param>
        public void DeleteSession(IAcDomain host, Guid sessionId)
        {
            var userSessionRepository = host.GetRequiredService<IRepository<UserSession>>();
            var userSessionEntity = userSessionRepository.GetByKey(sessionId);
            if (userSessionEntity != null)
            {
                userSessionRepository.Remove(userSessionEntity);
                userSessionRepository.Context.Commit();
            }
        }
        #endregion
    }
}