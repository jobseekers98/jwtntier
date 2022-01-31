﻿//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MODELfile.UtilityFolder
//{
//    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
//    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
//    {
//        private const string secret = "JWTSECRETFORTHETOKEN";


//        public void OnAuthorization(AuthorizationFilterContext context)
//        {
//            try
//            {
//                var token = context.HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

//                var tokenHandler = new JwtSecurityTokenHandler();
//                var key = Encoding.ASCII.GetBytes(secret);
//                tokenHandler.ValidateToken(token, new TokenValidationParameters
//                {
//                    ValidateIssuerSigningKey = true,
//                    IssuerSigningKey = new SymmetricSecurityKey(key),
//                    ValidateIssuer = false,
//                    ValidateAudience = false,
//                    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
//                    ClockSkew = TimeSpan.Zero
//                }, out SecurityToken validatedToken);

//                var jwtToken = (JwtSecurityToken)validatedToken;
//                var userId = jwtToken.Claims.First(x => x.Type == "id").Value;
//                //if (token != null)
//                //    attachUserToContext(context, userService, token);

//                //await _next(context);
//                //var user = (User)context.HttpContext.Items["User"];
//                if (userId == null)
//                {
//                    // not logged in
//                    context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
//                }
//            }
//            catch
//            {

//                context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
//            }
//        }

//    }
//}
