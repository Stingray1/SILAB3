using System;
using Org.BouncyCastle.Math;

namespace SI_Lab3
{
    class DSA
    {
        //Proprietati publice
        public BigInteger PrimQ { get; private set; } //getter e public, setter e private
        public BigInteger PrimP { get; private set; }
        public BigInteger G { get; private set; }
        public BigInteger CheiePrivataX { get; private set; }
        public BigInteger CheieY { get; private set; }
        public BigInteger hashMesaj;

        /// <summary>
        /// Constructor
        /// </summary>
        public DSA()
        {
            //folosim valori constante, pentru ca calcularea dinamica consuma resurse si timp
            PrimQ = new BigInteger("128664916901104973266511291028191037033198971751112445078249715264002164627920350035642172847816332403335167463621068780640378655179101420631474264335395927408157342415169138812753837532223865612162343145563656219573174164212648503877536732334417505809312276720089618985852934903819061132220713301192554312209");
            PrimP = new BigInteger("1105314709675064565342894220853376210421313787437");
            G     = new BigInteger("126295866394373430975797917950061188073992837731476988924782106444067625982515533459867756271621570843554264857052276327060329751584079739618118875576482345761244365929655735558056837983982439924354382946900511140747440168000782369323852709041493485074328689335372446697018193964090119248622129446650692618320");

            //Generam cheia privata
            CheiePrivataX = new BigInteger("742966077110400132007412245556843517580683026511");
            
            //Cheiile publice sunt: (PrimP, PrimQ, G, CheieY).
            CheieY = G.ModPow( CheiePrivataX, PrimP);
        }

        public BigInteger[] GenereazaSemnatura(string mesaj)
        {
            BigInteger k;
            BigInteger r = BigInteger.Zero;
            BigInteger s = BigInteger.Zero;
            BigInteger[] cheieDeSemnare = new BigInteger[2];//cheia de semnare mereu consta din numere; cream vector din 2 elemente

            hashMesaj = CalculeazaEncryption(mesaj, PrimQ);

            //atat timp cat r e egal cu 0 sau s e egal cu 0
            while (r.CompareTo(BigInteger.Zero) == -1 || s.CompareTo(BigInteger.Zero) <= 0 || s.CompareTo(PrimQ) >= 0 )
            {
                k = GenereazaUnBigIntegerAleator(PrimQ);
                r = G.ModPow(k, PrimP).Mod(PrimQ);
                k = k.ModInverse(PrimQ).Multiply(hashMesaj.Add(CheiePrivataX.Multiply(r)));
                s = k.Mod(PrimQ);

                cheieDeSemnare[0] = r;
                cheieDeSemnare[1] = s;
            }

            return cheieDeSemnare;
        }

        public bool VerificaSemnatura(BigInteger[] cheieDeSemnare, string mesaj, BigInteger msgHash, BigInteger y)
        {
            BigInteger r = cheieDeSemnare[0];
            BigInteger s = cheieDeSemnare[1];

            BigInteger hashMsg = CalculeazaEncryption(mesaj, PrimQ);
            if (hashMsg.CompareTo(msgHash) != 0)
                return false;

            //daca  0>r>q sau 0>s>q
            if (r.CompareTo(BigInteger.Zero) <= 0 || s.CompareTo(BigInteger.Zero) <= 0 || s.CompareTo(PrimQ) >= 0)
                return false;

            BigInteger w = s.ModInverse(PrimQ);

            BigInteger u1 = hashMsg.Multiply(w).Mod(PrimQ);
            BigInteger u2 = r.Multiply(w).Mod(PrimQ);

            u1 = G.ModPow(u1, PrimP);
            u2 = y.ModPow(u2, PrimP);

            BigInteger v = u1.Multiply(u2).Mod(PrimP).Mod(PrimQ);

            return hashMsg.CompareTo(msgHash) == 0;
        }

        BigInteger GenereazaUnBigIntegerAleator(BigInteger limita)
        {
            Random rand = new Random();
            int nrDeBiti = limita.BitLength;
            BigInteger result;

            do
            {
                result = new BigInteger(nrDeBiti, rand);
            } while (result.CompareTo(limita) >= 0 || result.CompareTo(BigInteger.Zero) <= 0);

            return result;
        }

        private BigInteger CalculeazaEncryption(string message, BigInteger q)
        {
            BigInteger result;
            byte[] bytes = GetBytes(message);

            if (q.BitLength >= bytes.Length * 8)
                result = new BigInteger(bytes);
            else
            {
                byte[] trunc = new byte[q.BitLength / 8];
                Array.Copy(bytes, 0, trunc, 0, trunc.Length);
                result = new BigInteger(trunc);
            }

            return result;
        }

        private byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }
    }
}
