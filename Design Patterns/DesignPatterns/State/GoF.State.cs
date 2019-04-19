using System;

namespace State
{

    abstract class ITCPState
    {
        abstract public void Open(TCPConnection con);
        abstract public void Close(TCPConnection con);
        abstract public void Send(TCPConnection con);
        protected void SetState(TCPConnection con, ITCPState state)
        {
            con.state = state;
        }
    }

    class TCPOpenned : ITCPState
    {
        public override void Close(TCPConnection con)
        {
            Console.WriteLine("fechando conexao");
            SetState(con, new TCPClosed()); // modo burro, so de exemplo
        }

        public override void Open(TCPConnection con)
        {
            Console.WriteLine("conexão já aberta");
        }

        public override void Send(TCPConnection con)
        {
            Console.WriteLine("enviar mensagem");
        }
    }
    class TCPClosed : ITCPState
    {
        public override void Close(TCPConnection con)
        {
            Console.WriteLine("conexão já fechada");
        }

        public override void Open(TCPConnection con)
        {
            Console.WriteLine("abrindo");
            SetState(con, new TCPOpenned());
        }

        public override void Send(TCPConnection con)
        {
            Console.WriteLine("impossível mandar mensagem com cone~xão fechada");
        }
    }


    class TCPConnection
    {
        internal ITCPState state;

        public TCPConnection()
        {
            state = new TCPClosed();
        }
        public void Open()
        { state.Open(this);}

        public void Close()
        { state.Close(this); }
        public void Send()
        { state.Send(this); }
    }

    class GoF
    {
        public static void Main(String[] args)
        {
            TCPConnection con = new TCPConnection();
            con.Send();
            con.Close();
            con.Open();
            con.Open();
            con.Send();
            con.Close();
            con.Send();

            Console.WriteLine("fim");
            Console.ReadLine();
        }
    }
}
