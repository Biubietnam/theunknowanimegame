using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D7D RID: 3453
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ReBattleAfterBattleLoseCsNotify : IMessage<ReBattleAfterBattleLoseCsNotify>, IMessage, IEquatable<ReBattleAfterBattleLoseCsNotify>, IDeepCloneable<ReBattleAfterBattleLoseCsNotify>, IBufferMessage
	{
		// Token: 0x17002B86 RID: 11142
		// (get) Token: 0x06009A42 RID: 39490 RVA: 0x0019A9EC File Offset: 0x00198BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ReBattleAfterBattleLoseCsNotify> Parser
		{
			get
			{
				return ReBattleAfterBattleLoseCsNotify._parser;
			}
		}

		// Token: 0x17002B87 RID: 11143
		// (get) Token: 0x06009A43 RID: 39491 RVA: 0x0019A9F3 File Offset: 0x00198BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReBattleAfterBattleLoseCsNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B88 RID: 11144
		// (get) Token: 0x06009A44 RID: 39492 RVA: 0x0019AA05 File Offset: 0x00198C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReBattleAfterBattleLoseCsNotify.Descriptor;
			}
		}

		// Token: 0x06009A45 RID: 39493 RVA: 0x0019AA0C File Offset: 0x00198C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReBattleAfterBattleLoseCsNotify()
		{
		}

		// Token: 0x06009A46 RID: 39494 RVA: 0x0019AA14 File Offset: 0x00198C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReBattleAfterBattleLoseCsNotify(ReBattleAfterBattleLoseCsNotify other) : this()
		{
			this.gJBOOFHBEOP_ = other.gJBOOFHBEOP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A47 RID: 39495 RVA: 0x0019AA39 File Offset: 0x00198C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReBattleAfterBattleLoseCsNotify Clone()
		{
			return new ReBattleAfterBattleLoseCsNotify(this);
		}

		// Token: 0x17002B89 RID: 11145
		// (get) Token: 0x06009A48 RID: 39496 RVA: 0x0019AA41 File Offset: 0x00198C41
		// (set) Token: 0x06009A49 RID: 39497 RVA: 0x0019AA49 File Offset: 0x00198C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GJBOOFHBEOP
		{
			get
			{
				return this.gJBOOFHBEOP_;
			}
			set
			{
				this.gJBOOFHBEOP_ = value;
			}
		}

		// Token: 0x06009A4A RID: 39498 RVA: 0x0019AA52 File Offset: 0x00198C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReBattleAfterBattleLoseCsNotify);
		}

		// Token: 0x06009A4B RID: 39499 RVA: 0x0019AA60 File Offset: 0x00198C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReBattleAfterBattleLoseCsNotify other)
		{
			return other != null && (other == this || (this.GJBOOFHBEOP == other.GJBOOFHBEOP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009A4C RID: 39500 RVA: 0x0019AA90 File Offset: 0x00198C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GJBOOFHBEOP)
			{
				num ^= this.GJBOOFHBEOP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009A4D RID: 39501 RVA: 0x0019AACF File Offset: 0x00198CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009A4E RID: 39502 RVA: 0x0019AAD7 File Offset: 0x00198CD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A4F RID: 39503 RVA: 0x0019AAE0 File Offset: 0x00198CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GJBOOFHBEOP)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.GJBOOFHBEOP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009A50 RID: 39504 RVA: 0x0019AB14 File Offset: 0x00198D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GJBOOFHBEOP)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009A51 RID: 39505 RVA: 0x0019AB46 File Offset: 0x00198D46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReBattleAfterBattleLoseCsNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GJBOOFHBEOP)
			{
				this.GJBOOFHBEOP = other.GJBOOFHBEOP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009A52 RID: 39506 RVA: 0x0019AB77 File Offset: 0x00198D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A53 RID: 39507 RVA: 0x0019AB80 File Offset: 0x00198D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GJBOOFHBEOP = input.ReadBool();
				}
			}
		}

		// Token: 0x04003BE3 RID: 15331
		private static readonly MessageParser<ReBattleAfterBattleLoseCsNotify> _parser = new MessageParser<ReBattleAfterBattleLoseCsNotify>(() => new ReBattleAfterBattleLoseCsNotify());

		// Token: 0x04003BE4 RID: 15332
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BE5 RID: 15333
		public const int GJBOOFHBEOPFieldNumber = 10;

		// Token: 0x04003BE6 RID: 15334
		private bool gJBOOFHBEOP_;
	}
}
