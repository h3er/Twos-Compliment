int num=Convert.ToInt32(Console.ReadLine());static string toBin(int num){string binNum="";int i=0;while(num-Math.Pow(2,i)>=0){i++;}for(int x=i;x>=0;x--){if(num-Math.Pow(2,x)>=0){binNum+="1";num-=(int)Math.Pow(2,x);}else{binNum+="0";}}return binNum;}string binNum=toBin(num); static string binAdd(string bin){string result="";bool carry=false;bool first=true;foreach(char c in bin.Reverse()){if(first){if(c=='1'){result+="0";carry=true;}else{result+="1";}first=false;continue;}if(c=='1'&&carry){result+="0";}else if(c=='1'&&!carry){result+="1";}else if(c=='0'&&carry){result+="1";carry=false;}else{result+="0";}}return new string(result.Reverse().ToArray());}static string twosComp(int num){string twosComp="";string bin=toBin(Math.Abs(num));foreach(char c in bin){twosComp+=Math.Abs(c-'1');}if(num<0){bin="1"+bin;}twosComp=binAdd(twosComp);return twosComp;}if(num<0){Console.WriteLine(toBin(Math.Abs(num)));}else{Console.WriteLine(twosComp(num));}
