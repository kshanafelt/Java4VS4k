using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antlr.Runtime
{

    using A4R = Antlr4.Runtime;

    public interface ICharStream : A4R.ICharStream
    {

    }

    public interface ITokenSource : A4R.ITokenSource
    {

        new IToken NextToken();

    }
    
    public interface IToken : A4R.IToken
    {

    }

    public static class CharStreamConstants
    {

        public const int EndOfFile = A4R.IntStreamConstants.Eof;

    }

    public abstract class Lexer : A4R.Lexer, ITokenSource
    {

        public Lexer(A4R.ICharStream input) : base(input) { }

        //private Lexer(Lexer lexer) : base(lexer._input)
        //{
        //    this._input = lexer._input;
        //    this._tokenFactorySourcePair = lexer._tokenFactorySourcePair;
        //    this._token = lexer._token;
        //    this._type = lexer._type;
        //    this._channel = lexer._channel;
        //    this._tokenStartCharIndex          = -1;
        //    this._tokenStartCharPositionInLine = -1;
        //    this._tokenStartLine               = -1;
        //    this._text                         = (string) null;
        //    this._hitEOF                       = false;
        //    this._mode                         = 0;
        //    this._modeStack.Clear();
        //    this.Interpreter.Reset();

        //}

        public new IToken NextToken()
        {
            return (IToken)base.NextToken();
        }

        public static implicit operator Lexer(A4R.Lexer lexer)
        {
            return (Lexer)lexer;
        }

        //IToken A4R.ITokenSource.NextToken() { throw new NotImplementedException();  }

    }

}
