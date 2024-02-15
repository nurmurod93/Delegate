using Delegat2024;
using System.Numerics;

Ishtirokchi ishtirokchi1 = new Ishtirokchi("Bobur");
Ishtirokchi ishtirokchi2 = new Ishtirokchi("Samandar");
Ishtirokchi ishtirokchi3 = new Ishtirokchi("Sevinch");
Ishtirokchi ishtirokchi4 = new Ishtirokchi("Ismoil");
Ishtirokchi ishtirokchi5 = new Ishtirokchi("Ra'no");

Musobaqa musobaqa = new Musobaqa((ishtirokchi1, ishtirokchi2) => ishtirokchi1.JamiBall > ishtirokchi2.JamiBall ? ishtirokchi1 : ishtirokchi2);

musobaqa.IshtirokchiQosh(ishtirokchi1);
musobaqa.IshtirokchiQosh(ishtirokchi2);
musobaqa.IshtirokchiQosh(ishtirokchi3);
musobaqa.IshtirokchiQosh(ishtirokchi4);
musobaqa.IshtirokchiQosh(ishtirokchi5);

int roundlarSoni = 5;
for (int i = 0; i < roundlarSoni; i++)
{
    musobaqa.RoundniIjroEt();
}

Ishtirokchi muzaffar = musobaqa.MuzaffarniTop();

Console.WriteLine("Ishtirokchilar:");
Console.WriteLine("-----------------");
Console.WriteLine(string.Join("\n", musobaqa.Ishtirokchilar));
Console.WriteLine();

Ishtirokchi JamiBaliYuqoriBolganIshtirokchiniAniqla(Ishtirokchi ish1, Ishtirokchi ish2)
{
    if (ish1.JamiBall > ish2.JamiBall)
    {
        return ish1;
    }
    else
    {
        return ish2;
    }
}

Ishtirokchi JamiBaliPastBolganIshtirokchiniAniqla(Ishtirokchi ish1, Ishtirokchi ish2)
{
    if (ish1.JamiBall < ish2.JamiBall)
    {
        return ish1;
    }
    else
    {
        return ish2;
    }
}

Ishtirokchi JamiBaliKeyinMaksimalBallYuqoriBolganIshtirokchiniAniqla(Ishtirokchi ish1, Ishtirokchi ish2)
{
    if(ish1.JamiBall > ish2.JamiBall)
    {
        return ish1;
    }
    else if(ish2.JamiBall > ish1.JamiBall) 
    {
        return ish2;
    }
    else
    {
        if(ish1.MaxBall > ish2.MaxBall)
        {
            return ish1;
        }
        else 
        {
            return ish2;
        }
    }
    
}