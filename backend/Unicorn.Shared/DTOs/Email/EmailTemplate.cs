﻿namespace Unicorn.Shared.DTOs.Email
{
    public static class EmailTemplate
    {
        private static string head = "<!doctype html><html> <head> <meta name='viewport' content='width=device-width' /> <meta http-equiv='Content-Type' content='text/html; charset=UTF-8' /> <title>Simple Transactional Email</title> <link rel='stylesheet' href='https://cdnjs.cloudflare.com/ajax/libs/semantic-ui/2.2.9/semantic.min.css'/>  <style> /* ------------------------------------- GLOBAL RESETS ------------------------------------- */ img { border: none; -ms-interpolation-mode: bicubic; max-width: 100%; } body { background-color: #f6f6f6; font-family: sans-serif; -webkit-font-smoothing: antialiased; font-size: 14px; line-height: 1.4; margin: 0; padding: 0; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; } table { border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; } table td { font-family: sans-serif; font-size: 14px; vertical-align: top; } /* ------------------------------------- BODY & CONTAINER ------------------------------------- */ .body { background-color: #f6f6f6; width: 100%; } /* Set a max-width, and make it display as block so it will automatically stretch to that width, but will also shrink down on a phone or something */ .container { display: block; Margin: 0 auto !important; /* makes it centered */ max-width: 580px; padding: 10px; width: 580px; } /* This should also be a block element, so that it will fill 100% of the .container */ .content { box-sizing: border-box; display: block; Margin: 0 auto; max-width: 580px; padding: 10px; } /* ------------------------------------- HEADER, FOOTER, MAIN ------------------------------------- */ .main { background: #ffffff; border-bottom-right-radius: 3px; border-bottom-left-radius: 3px; width: 100%; } .wrapper { box-sizing: border-box; padding: 20px; } .content-block { padding-bottom: 10px; padding-top: 10px; } .footer { color: #999999; border-top: 1px solid #f2f2f2; clear: both; background-color: white; text-align: center; width: 100%; } .footer td, .footer p, .footer span, .footer a { color: #666666; font-size: 12px; text-align: center; } /* ------------------------------------- TYPOGRAPHY ------------------------------------- */ h1, h2, h3, h4 { color: #000000; font-family: sans-serif; font-weight: 400; line-height: 1.4; margin: 0; Margin-bottom: 30px; } h1 { font-size: 35px; font-weight: 300; text-align: center; text-transform: capitalize; } p, ul, ol { font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px; } p li, ul li, ol li { list-style-position: inside; margin-left: 5px; } a { color: #ff8080; text-decoration: underline; } /* ------------------------------------- BUTTONS ------------------------------------- */ .btn { box-sizing: border-box; width: 100%; } .btn > tbody > tr > td { padding-bottom: 15px; } .btn table { width: auto; } .btn table td { background-color: #ffffff; border-radius: 5px; text-align: center; } .btn a { background-color: #ffffff; border: solid 1px #ff8080; border-radius: 5px; box-sizing: border-box; color: #ff8080; cursor: pointer; display: inline-block; font-size: 14px; font-weight: bold; margin: 0; padding: 12px 25px; text-decoration: none; text-transform: capitalize; } .btn-primary table td { background-color: #ff8080; } .btn-primary a { background-color: #ff8080; border-color: #ff8080; color: #ffffff; } /* ------------------------------------- OTHER STYLES THAT MIGHT BE USEFUL ------------------------------------- */ .last { margin-bottom: 0; } .first { margin-top: 0; } .align-center { text-align: center; } .align-right { text-align: right; } .align-left { text-align: left; } .clear { clear: both; } .mt0 { margin-top: 0; } .mb0 { margin-bottom: 0; } .preheader { color: transparent; display: none; height: 0; max-height: 0; max-width: 0; opacity: 0; overflow: hidden; mso-hide: all; visibility: hidden; width: 0; } .powered-by a { text-decoration: none; } hr { border: 0; border-bottom: 1px solid #f6f6f6; Margin: 20px 0; } /* ------------------------------------- RESPONSIVE AND MOBILE FRIENDLY STYLES ------------------------------------- */ @media only screen and (max-width: 620px) { table[class=body] h1 { font-size: 28px !important; margin-bottom: 10px !important; } table[class=body] p, table[class=body] ul, table[class=body] ol, table[class=body] td, table[class=body] span, table[class=body] a { font-size: 16px !important; } table[class=body] .wrapper, table[class=body] .article { padding: 10px !important; } table[class=body] .content { padding: 0 !important; } table[class=body] .container { padding: 0 !important; width: 100% !important; } table[class=body] .main { border-left-width: 0 !important; border-radius: 0 !important; border-right-width: 0 !important; } table[class=body] .btn table { width: 100% !important; } table[class=body] .btn a { width: 100% !important; } table[class=body] .img-responsive { height: auto !important; max-width: 100% !important; width: auto !important; }} /* ------------------------------------- PRESERVE THESE STYLES IN THE HEAD ------------------------------------- */ @media all { .ExternalClass { width: 100%; } .ExternalClass, .ExternalClass p, .ExternalClass span, .ExternalClass font, .ExternalClass td, .ExternalClass div { line-height: 100%; } .apple-link a { color: inherit !important; font-family: inherit !important; font-size: inherit !important; font-weight: inherit !important; line-height: inherit !important; text-decoration: none !important; } .btn-primary table td:hover { background-color: #ff8080 !important; } .btn-primary a:hover { background-color: #ff8080 !important; border-color: #ff8080 !important; } } /* ------------------------------------- MY STYLES ------------------------------------- */ .mail-header { border-top-left-radius: 3px; border-top-right-radius: 3px; padding-top: 10px; padding-left: 20px; height: 60px; background-color: white; border-bottom: 1px solid #f2f2f2; position: relative } .unicorn-logo { width: 50px; height: 50px; position: absolute; } .mail-header>h2 { margin-top: 10px; color: #808080; } .my-btn { width: 35%; font-size: 16px!important; font-weight: normal!important; background-color: #ff8080!important; color: white!important; } .my-btn:active { background-color: #ff8080!important; color: white!important; } .my-btn:hover { background-color: #ff6666!important; color: white!important; } </style> </head> <body class=''> <table border='0' cellpadding='0' cellspacing='0' class='body'> <tr> <td>&nbsp;</td> <td class='container'> <div class='content'> <!-- START CENTERED WHITE CONTAINER --> <div class='mail-header'> <a href='http://unicorn-bsa.tk'><img class='unicorn-logo' src='https://i.imgur.com/XYYFKtG.png'></a>  </div> <table class=\"main\">";
        private static string footer = "</table> <!-- START FOOTER --> <div class='footer' style='color: #999999; border-top: 0px solid #f2f2f2; clear: both; background-color: white; text-align: center; width: 100%;'> <table style='border-top: 1px solid #f2f2f2;' bgcolor=white border='0' cellpadding='0' cellspacing='0'> <tr> <td class='content-block'> <span class='apple-link'>Unicorn Inc, Chornovola Ave 59, Lviv 79058</span> <br><br> +380984905343 &nbsp;&nbsp; <a style=\"text-decoration:none\" href=\"mailto:academy@binary-studio.com\"> <img style=\"width: 12px; height: 12px\" src=\"https://i.imgur.com/q21PIOw.png\"> </a>&nbsp; <a style=\"text-decoration:none\" href=\"https://www.facebook.com/BinaryStudioAcademy\"> <img style=\"width: 12px; height: 12px\" src=\"https://i.imgur.com/asPzmbp.jpg\"> </a>&nbsp; <a style=\"text-decoration:none\" href=\"https://vk.com/binary_academy\"> <img style=\"width: 12px; height: 12px\" src=\"https://i.imgur.com/p8RViIh.jpg\"> </a> </td> </tr> <tr> <td class='content-block powered-by'> Powered by <a href='http://unicorn-bsa.tk'>Unicorn Project</a>. </td> </tr> </table> </div> <!-- END FOOTER --> <!-- END CENTERED WHITE CONTAINER --> </div> </td> <td>&nbsp;</td> </tr> </table> </body></html>";

        private const string dashBoardLink = "http://unicorn-bsa.tk/dashboard";
        private const string accountLink = "http://unicorn-bsa.tk/user/";

        private static string BuildHtml(string body)
        {
            return $"{head}{body}{footer}";
        }

        public static string NewOrderTemplate(string personFirstName, string personeLastName, string workName, long id)
        {
            string body = $"<tr> <td class='wrapper'> <table border='0' cellpadding='0' cellspacing='0'> <tr> <td> <h3>Hi there,</h3> <p style='color:#4d4d4d'><a href=http://unicorn-bsa.tk/user/{id} >{personFirstName} {personeLastName}</a> booked {workName}. You can review details of this order in your dashboard.</p> <br> <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"btn btn-primary\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; box-sizing: border-box; width: 100%; \" width=\"100% \"> <tbody> <tr> <td align=\"center\" style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; padding-bottom: 15px; \" valign=\"top\"> <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 30%; \"> <tbody> <tr> <td style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; border-radius: 5px; text-align: center; background-color: #ff8080\" valign=\"top\" align=\"center\" bgcolor=\"#ff8080\"> <a href=\"{dashBoardLink}\" target=\"_blank\" style=\"border: solid 1px #ff8080; border-radius: 5px; box-sizing: border-box; cursor: pointer; display: inline-block; font-size: 14px; font-weight: bold; margin: 0; padding: 12px 25px; text-decoration: none; text-transform: capitalize; background-color: #ff8080; border-color: #ff8080; color: #ffffff;\">Dashboard</a> </td> </tr> </tbody> </table> </td> </tr> </tbody> </table></td> </tr> </table> </td> </tr>";
            return BuildHtml(body);
        }

        public static string OrderStatusChanged(string workName, string status, long accountId)
        {
            string body = $"<tr> <td class='wrapper'> <table border='0' cellpadding='0' cellspacing='0'> <tr> <td> <h3>Hi there,</h3> <p style='color:#4d4d4d'>New information about your task ({workName}): <b>{status}</b>. You can review details in your account.</p> <br> <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"btn btn-primary\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; box-sizing: border-box; width: 100%; \" width=\"100% \"> <tbody> <tr> <td align=\"center\" style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; padding-bottom: 15px; \" valign=\"top\"> <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 30%; \"> <tbody> <tr> <td style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; border-radius: 5px; text-align: center; background-color: #ff8080\" valign=\"top\" align=\"center\" bgcolor=\"#ff8080\"> <a href=\"{accountLink}{accountId}\" target=\"_blank\" style=\"border: solid 1px #ff8080; border-radius: 5px; box-sizing: border-box; cursor: pointer; display: inline-block; font-size: 14px; font-weight: bold; margin: 0; padding: 12px 25px; text-decoration: none; text-transform: capitalize; background-color: #ff8080; border-color: #ff8080; color: #ffffff;\">Account</a> </td> </tr> </tbody> </table> </td> </tr> </tbody> </table> </td> </tr> </table> </td> </tr>";
            return BuildHtml(body);
        }

        public static string NewOfferTemplate(string company, long companyId)
        {
            string body = $"<tr> <td class='wrapper'> <table border='0' cellpadding='0' cellspacing='0'> <tr> <td> <h3>Hi there,</h3> <p style='color:#4d4d4d'><a href='http://unicorn-bsa.tk/vendor/{companyId}'>{company}</a> has offered you to join their team. You can review details of this offer and make choice in your dashboard.</p> <br> <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"btn btn-primary\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; box-sizing: border-box; width: 100%; \" width=\"100% \"> <tbody> <tr> <td align=\"center\" style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; padding-bottom: 15px; \" valign=\"top\"> <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 30%; \"> <tbody> <tr> <td style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; border-radius: 5px; text-align: center; background-color: #ff8080\" valign=\"top\" align=\"center\" bgcolor=\"#ff8080\"> <a href=\"{dashBoardLink}\" target=\"_blank\" style=\"border: solid 1px #ff8080; border-radius: 5px; box-sizing: border-box; cursor: pointer; display: inline-block; font-size: 14px; font-weight: bold; margin: 0; padding: 12px 25px; text-decoration: none; text-transform: capitalize; background-color: #ff8080; border-color: #ff8080; color: #ffffff;\">Dashboard</a> </td> </tr> </tbody> </table> </td> </tr> </tbody> </table> </td> </tr> </table> </td> </tr>";
            return BuildHtml(body);
        }

        public static string OfferStatusChanged(string vendor, string status, long companyId, long vendorId)
        {
            string body = $"<tr> <td class='wrapper'> <table border='0' cellpadding='0' cellspacing='0'> <tr> <td> <h3>Hi there,</h3> <p style='color:#4d4d4d'><a href='http://unicorn-bsa.tk/vendor/{vendorId}'>{vendor}</a> has {status} your offer. You can review details of this event in your vendors page.</p> <br> <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"btn btn-primary\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; box-sizing: border-box; width: 100%; \" width=\"100% \"> <tbody> <tr> <td align=\"center\" style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; padding-bottom: 15px; \" valign=\"top\"> <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 30%; \"> <tbody> <tr> <td style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; border-radius: 5px; text-align: center; background-color: #ff8080\" valign=\"top\" align=\"center\" bgcolor=\"#ff8080\"> <a href=\"http://unicorn-bsa.tk/company/{companyId}/edit?tab=vendors \" target=\"_blank\" style=\"border: solid 1px #ff8080; border-radius: 5px; box-sizing: border-box; cursor: pointer; display: inline-block; font-size: 14px; font-weight: bold; margin: 0; padding: 12px 25px; text-decoration: none; text-transform: capitalize; background-color: #ff8080; border-color: #ff8080; color: #ffffff;\">Vendors page</a> </td> </tr> </tbody> </table> </td> </tr> </tbody> </table></td> </tr> </table> </td> </tr>";
            return BuildHtml(body);
        }
    }
}