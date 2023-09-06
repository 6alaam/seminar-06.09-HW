Console.Write("Введите пятизначное число ");
string n = Console.ReadLine();


bool b = true;

for (int i = 0 ; i < n.Length /2 ; i++){
    
    if (n[i] != n[n.Length - 1 - i]){
        b = false; 
                break;
    } 
    
}

System.Console.WriteLine(b);
