// convert min2hr / hr2min. best way i can think of
using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine(converttype(2,false));
      Console.WriteLine(converttype(180,true));
      Console.Write(converttype(200,true));
      
      /* output
        2 hr = 120 minutes
        180 min = 3hr & 0 minutes
        200 min = 3hr & 20 minutes */
  }
  
  static string converttype(int time,bool min2hr){
      
      if(min2hr)
          return time+" min = "+time/60+"hr & " +(time-((time/60)*60))+" minutes";
      return time+" hr = "+time*60+" minutes";      
  }
}