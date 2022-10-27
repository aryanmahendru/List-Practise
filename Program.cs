var list= new List<string>{"January","June","July"};
Console.WriteLine(string.Join(",",list));

var list1=new List<string>();
for (int i=0;i<700;i++){
    list1.Add("joy");
}
Console.WriteLine(string.Join(",",list1));

var list2 =new List<int>();
for(int a=0;a<500;a++){
    list2.Add(7);
}
Console.WriteLine(string.Join(",",list2));

Random rnd =new Random();
var list3=new List<int>();
for(int b=0;b<5000;b++){
    int randominteger=rnd.Next(0,100);
    list3.Add(randominteger);
}
Console.WriteLine(string.Join(",",list3));

var list4=new List<int>();
for (int c=0;c<300;c++){
    int randominteger1=rnd.Next(0,40);
    list4.Add(randominteger1);
}
Console.WriteLine(string.Join(",",list4));

var list5=new List<int>();
for(int d=20;d<801;d+=4){
    list5.Add(d);
}
Console.WriteLine(string.Join(",",list5));

var list6=new List<int>();
for(int e=100;e>9;e-=2){
    list6.Add(e);
}
Console.WriteLine(string.Join(",",list6));

string colourstr= "red,orange,yellow,green,blue,indigo,violet";
List<string> colournames=colourstr.Split(",").ToList();


string citystr= "Edmonton,Calgary,Vancouver,Saskatoon,Winnipeg";
List<string> citynames=citystr.Split(";").ToList();  


var list9=new List<string>();
bool loop=true;
while(loop){
    Console.WriteLine("Please enter a name to add in list ");
    string addname=Console.ReadLine();
    if (addname == "done"){
        loop=false;
    }
    else{
        list9.Add(addname);
    }
}
