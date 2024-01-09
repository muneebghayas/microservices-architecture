using System;
using System.Net;
using System.Text;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CertificatePRJ.Services.IService;
using System.IO;

namespace CertificatePRJ.Services.Service
{
	public class AuthService : IAuthService
	{
		#region Global
		private const string Entity = "Auth";

		public AuthService()
		{
		}

		#endregion
		//public async Task<ResponseDto<LoginResponseDto>> GetAuthData(LoginDto dto)
		//{
		//	bool isArabic = _commonMethods.languageRegion();
		//	dto.Password = AesOperation.EncryptString(AesEncryptionAdDecryptionKey.AesKey, dto.Password);
		//	bool isprofileComplete = false;
		//	var user = await _userRepository.GetSingle(x => x.Email == dto.Email && x.Password.Equals(dto.Password) && x.IsActive == true && x.IsDeleted == false);
		//	if (user is null)
		//	{
		//		return new ResponseDto<LoginResponseDto>()
		//		{
		//			Status = 0,
		//			Message = "البريد الإلكتروني أو كلمة المرور غير صحيحة", //"Username or password is invalid",
		//			Data = null
		//		};
		//	}

		//	if ((user.FullName != null || user.FullNameEn != null) && user.Cv != null && user.Specialization != null && user.GraduationYear != null &&
		//		user.DegreeId > 0 && user.GenderId > 0 && user.GovernorateId > 0 && user.WilayaId > 0 && user.ApplicantTypeId > 0)
		//	{
		//		isprofileComplete = true;
		//	}
		//	var rec = await (from l in _userRepository.AsQueryable().Where(x => x.Email.Equals(dto.Email) && x.Password.Equals(dto.Password) && x.IsActive == true && x.IsDeleted == false)
		//					 join aur in _appUserRoleRepository.AsQueryable() on l.Id equals aur.AppUserId
		//					 join ar in _appRolesRepository.AsQueryable() on aur.AppRoleId equals ar.Id
		//					 select new LoginResponseDto
		//					 {
		//						 UserId = l.Id,
		//						 RoleId = aur.AppRoleId.Value,
		//						 Name = l.FullNameEn,
		//						 FirstName = l.FirstNameEn,
		//						 SecondName = l.SecondNameEn,
		//						 ThirdName = l.ThirdNameEn,
		//						 FamilyName = l.FamilyNameEn,
		//						 ArabicName = l.FullName,
		//						 ArabicFirstName = l.FirstName,
		//						 ArabicSecondName = l.SecondName,
		//						 ArabicThirdName = l.ThirdName,
		//						 ArabicFamilyName = l.FamilyName,
		//						 Email = l.Email,
		//						 IsFirstLoginAttempt = isprofileComplete == true ? false : true,
		//						 isVerify = l.IsVerify == null ? false : l.IsVerify,
		//						 CivilCr = l.CivilCR,
		//						 Nationality = l.Nationality,
		//						 DateOfBirth = l.DateOfBirth,
		//						 PhoneNumber = l.PhoneNumber,
		//						 IsActive = l.IsActive == null ? false : l.IsActive,
		//						 IsDeleted = l.IsDeleted == false ? false : l.IsDeleted,
		//						 LogoFilePath = l.LogoFilePath,
		//						 Specialization = l.Specialization,
		//						 GraduationYear = l.GraduationYear,
		//						 MOLVerifiedStatusId = l.MOLVerifiedStatusId,
		//						 IsProfileComplete = l.IsProfileComplete.Value

		//					 }).FirstOrDefaultAsync();
		//	if (rec is null)
		//	{
		//		return new ResponseDto<LoginResponseDto>()
		//		{
		//			Status = 0,
		//			Message = "البريد الإلكتروني أو كلمة المرور غير صحيحة", //"Username or password is invalid",
		//			Data = null
		//		};
		//	}
		//	if (rec.isVerify.Value)
		//	{
		//		var tokenResp = GenerateAuthenticationResultForUser(rec, rec.RoleId);
		//		rec.Token = tokenResp.Token;
		//		if (rec.IsFirstLoginAttempt == null || rec.IsFirstLoginAttempt == true)
		//		{
		//			var response = await _userRepository.GetSingle(x => x.Id == rec.UserId);
		//			response.isFirstLoginAttempt = false;
		//			await _userRepository.Update(response);
		//		}
		//	}

		//	return Responses.OK("User Login Successful.", rec);

		//}
	}
}
