﻿using FTJFundChoice.OrionModels.Security;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FTJFundChoice.OrionClient.Interfaces {

    public interface IUserModule : ICommonRead<UserInfoDetails>, ICommonModify<UserInfoDetails> {

        Task<IResult<List<long>>> Activate(bool isActive, List<long> ids);

        Task<IResult<UserInfoDetails>> Create(UserInfoDetails user, bool sendEmail = false);

        Task<IResult> Delete(UserInfoDetails user);

        Task<IResult> Delete(long userId);

        Task<IResult<List<UserInfoDetails>>> GetAll(bool? isActive = null, string loginUserId = null);

        Task<IResult<UserInfoDetails>> ResetPassword(long userId, string password, bool sendEmail = false, bool newUser = false);

        Task<IResult<UserInfoDetails>> ResetPassword(UserInfoDetails user, bool sendEmail = false, bool newUser = false);

        Task<IResult<UserInfoDetails>> SetPassword(long userId, string password);

        Task<IResult<UserInfoDetails>> SetPassword(UserInfoDetails user);
    }
}