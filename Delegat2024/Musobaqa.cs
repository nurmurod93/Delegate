namespace Delegat2024
{
    public delegate Ishtirokchi YutuqQoidasi(Ishtirokchi ishtirokchi1, Ishtirokchi ishtirokchi2);

    public class Musobaqa
    {
        private const int MaxBallarRoundUchun = 50;
        private static readonly Random rendom = new Random();
        private YutuqQoidasi yutuqQoidasi;

        public List<Ishtirokchi> Ishtirokchilar { get; } = new List<Ishtirokchi>();

        public Musobaqa(YutuqQoidasi yutuqQoidasi)
        {
            this.yutuqQoidasi = yutuqQoidasi;
        }
        public void IshtirokchiQosh(Ishtirokchi ishtirokchi)
        {
            Ishtirokchilar.Add(ishtirokchi);
        }

        public void RoundniIjroEt()
        {
            foreach (var ishtirokchi in Ishtirokchilar)
            {
                int randomBal = rendom.Next(MaxBallarRoundUchun + 1);
                ishtirokchi.BallarniHisoblash(randomBal);
            }
        }
        public Ishtirokchi MuzaffarniTop()
        {
            Ishtirokchi muzaffar = Ishtirokchilar[0];
            for(int i = 1; i < Ishtirokchilar.Count; i++) 
            {
                Ishtirokchi ishtirokchi = Ishtirokchilar[i];
                muzaffar = yutuqQoidasi.Invoke( muzaffar, ishtirokchi);
            }
            return muzaffar;
        }
    }

}
