namespace teamProject
{
    class Entp
    {
        public string entpName { get; set; }
        public string entpTel { get; set; }
        public string entpAddr { get; set; }
        public string entpEmail { get; set; }

        public Entp(string entpName, string entpTel, string entpAddr, string entpEmail)
        {
            this.entpName = entpName;
            this.entpTel = entpTel;
            this.entpAddr = entpAddr;
            this.entpEmail = entpEmail;
        }

        public Entp()
        {

        }
    }
}
