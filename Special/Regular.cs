// Regular -- Parse tree node strategy for printing regular lists

using System;

namespace Tree
{
    public class Regular : Special
    {
        public Regular() { }

        public override void print(Node t, int n, bool p)
        {
            Printer.printRegular(t, n, p);
        }

        public override Node eval(Node t, Environment env)
        {
            //builtin or closure I think
            Node implementation = env.lookup(t.getCar());
            //for "car", implementation is definitely a builtin
            return implementation.apply(t.getCdr());
        }
        //Functions are given the regular form
        /**
        closure(fac).apply((5))
        .
       / \
     foo


    */
    }
}


