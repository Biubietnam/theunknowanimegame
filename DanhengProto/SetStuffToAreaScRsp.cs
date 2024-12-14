using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001139 RID: 4409
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetStuffToAreaScRsp : IMessage<SetStuffToAreaScRsp>, IMessage, IEquatable<SetStuffToAreaScRsp>, IDeepCloneable<SetStuffToAreaScRsp>, IBufferMessage
	{
		// Token: 0x17003771 RID: 14193
		// (get) Token: 0x0600C49E RID: 50334 RVA: 0x0020FB77 File Offset: 0x0020DD77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetStuffToAreaScRsp> Parser
		{
			get
			{
				return SetStuffToAreaScRsp._parser;
			}
		}

		// Token: 0x17003772 RID: 14194
		// (get) Token: 0x0600C49F RID: 50335 RVA: 0x0020FB7E File Offset: 0x0020DD7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetStuffToAreaScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003773 RID: 14195
		// (get) Token: 0x0600C4A0 RID: 50336 RVA: 0x0020FB90 File Offset: 0x0020DD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetStuffToAreaScRsp.Descriptor;
			}
		}

		// Token: 0x0600C4A1 RID: 50337 RVA: 0x0020FB97 File Offset: 0x0020DD97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetStuffToAreaScRsp()
		{
		}

		// Token: 0x0600C4A2 RID: 50338 RVA: 0x0020FBA0 File Offset: 0x0020DDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetStuffToAreaScRsp(SetStuffToAreaScRsp other) : this()
		{
			this.pos_ = other.pos_;
			this.retcode_ = other.retcode_;
			this.pOEDFMELAKE_ = other.pOEDFMELAKE_;
			this.nOJOJKCJEOI_ = other.nOJOJKCJEOI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C4A3 RID: 50339 RVA: 0x0020FBF4 File Offset: 0x0020DDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetStuffToAreaScRsp Clone()
		{
			return new SetStuffToAreaScRsp(this);
		}

		// Token: 0x17003774 RID: 14196
		// (get) Token: 0x0600C4A4 RID: 50340 RVA: 0x0020FBFC File Offset: 0x0020DDFC
		// (set) Token: 0x0600C4A5 RID: 50341 RVA: 0x0020FC04 File Offset: 0x0020DE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DAEALPIOKMG Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x17003775 RID: 14197
		// (get) Token: 0x0600C4A6 RID: 50342 RVA: 0x0020FC0D File Offset: 0x0020DE0D
		// (set) Token: 0x0600C4A7 RID: 50343 RVA: 0x0020FC15 File Offset: 0x0020DE15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17003776 RID: 14198
		// (get) Token: 0x0600C4A8 RID: 50344 RVA: 0x0020FC1E File Offset: 0x0020DE1E
		// (set) Token: 0x0600C4A9 RID: 50345 RVA: 0x0020FC26 File Offset: 0x0020DE26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint POEDFMELAKE
		{
			get
			{
				return this.pOEDFMELAKE_;
			}
			set
			{
				this.pOEDFMELAKE_ = value;
			}
		}

		// Token: 0x17003777 RID: 14199
		// (get) Token: 0x0600C4AA RID: 50346 RVA: 0x0020FC2F File Offset: 0x0020DE2F
		// (set) Token: 0x0600C4AB RID: 50347 RVA: 0x0020FC37 File Offset: 0x0020DE37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NOJOJKCJEOI
		{
			get
			{
				return this.nOJOJKCJEOI_;
			}
			set
			{
				this.nOJOJKCJEOI_ = value;
			}
		}

		// Token: 0x0600C4AC RID: 50348 RVA: 0x0020FC40 File Offset: 0x0020DE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetStuffToAreaScRsp);
		}

		// Token: 0x0600C4AD RID: 50349 RVA: 0x0020FC50 File Offset: 0x0020DE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetStuffToAreaScRsp other)
		{
			return other != null && (other == this || (this.Pos == other.Pos && this.Retcode == other.Retcode && this.POEDFMELAKE == other.POEDFMELAKE && this.NOJOJKCJEOI == other.NOJOJKCJEOI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C4AE RID: 50350 RVA: 0x0020FCBC File Offset: 0x0020DEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Pos != DAEALPIOKMG.WorkPosNone)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.POEDFMELAKE != 0U)
			{
				num ^= this.POEDFMELAKE.GetHashCode();
			}
			if (this.NOJOJKCJEOI != 0U)
			{
				num ^= this.NOJOJKCJEOI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C4AF RID: 50351 RVA: 0x0020FD4C File Offset: 0x0020DF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C4B0 RID: 50352 RVA: 0x0020FD54 File Offset: 0x0020DF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C4B1 RID: 50353 RVA: 0x0020FD60 File Offset: 0x0020DF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Pos != DAEALPIOKMG.WorkPosNone)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Pos);
			}
			if (this.POEDFMELAKE != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.POEDFMELAKE);
			}
			if (this.NOJOJKCJEOI != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.NOJOJKCJEOI);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C4B2 RID: 50354 RVA: 0x0020FDF4 File Offset: 0x0020DFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Pos != DAEALPIOKMG.WorkPosNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Pos);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.POEDFMELAKE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.POEDFMELAKE);
			}
			if (this.NOJOJKCJEOI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NOJOJKCJEOI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C4B3 RID: 50355 RVA: 0x0020FE7C File Offset: 0x0020E07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetStuffToAreaScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Pos != DAEALPIOKMG.WorkPosNone)
			{
				this.Pos = other.Pos;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.POEDFMELAKE != 0U)
			{
				this.POEDFMELAKE = other.POEDFMELAKE;
			}
			if (other.NOJOJKCJEOI != 0U)
			{
				this.NOJOJKCJEOI = other.NOJOJKCJEOI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C4B4 RID: 50356 RVA: 0x0020FEF4 File Offset: 0x0020E0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C4B5 RID: 50357 RVA: 0x0020FF00 File Offset: 0x0020E100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 16U)
					{
						this.Pos = (DAEALPIOKMG)input.ReadEnum();
						continue;
					}
					if (num == 24U)
					{
						this.POEDFMELAKE = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.NOJOJKCJEOI = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004F6D RID: 20333
		private static readonly MessageParser<SetStuffToAreaScRsp> _parser = new MessageParser<SetStuffToAreaScRsp>(() => new SetStuffToAreaScRsp());

		// Token: 0x04004F6E RID: 20334
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F6F RID: 20335
		public const int PosFieldNumber = 2;

		// Token: 0x04004F70 RID: 20336
		private DAEALPIOKMG pos_;

		// Token: 0x04004F71 RID: 20337
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04004F72 RID: 20338
		private uint retcode_;

		// Token: 0x04004F73 RID: 20339
		public const int POEDFMELAKEFieldNumber = 3;

		// Token: 0x04004F74 RID: 20340
		private uint pOEDFMELAKE_;

		// Token: 0x04004F75 RID: 20341
		public const int NOJOJKCJEOIFieldNumber = 6;

		// Token: 0x04004F76 RID: 20342
		private uint nOJOJKCJEOI_;
	}
}
