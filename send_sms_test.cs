using System ;

namespace SMS {
  public class send_sms_test {
		public send_sms_test() {
		}
		public void doSend() {
			string time_now = DateTime.Now.ToString( "dd\\/MM\\/yyyy h\\:mm tt" ) ;                                    
            string message = "Your Message" ;
			string call_back_data = "Callback Data" ;
			string app_id = "pm0ALE0JBgvUswLrlZiy" ;
			string[] addresses = { "tel:+8801700000000" } ;

            SMS.SendSms sS = new SMS.SendSms( "POST" , "tel%3A%2B8801700000000" ) ;						
            sS.initAuth( "abc@abc.com" , "your_password" ) ;
            sS.setSsl() ;
            sS.setTimeOut( 300 ) ;            
			sS.jsonEncode( addresses , call_back_data , message , app_id ) ;
            sS.Execute() ;
		}
	}
}
