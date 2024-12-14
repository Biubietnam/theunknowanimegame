using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A17 RID: 2583
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LJFBDHHDPOM : IMessage<LJFBDHHDPOM>, IMessage, IEquatable<LJFBDHHDPOM>, IDeepCloneable<LJFBDHHDPOM>, IBufferMessage
	{
		// Token: 0x17002049 RID: 8265
		// (get) Token: 0x060072C7 RID: 29383 RVA: 0x00131AD9 File Offset: 0x0012FCD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LJFBDHHDPOM> Parser
		{
			get
			{
				return LJFBDHHDPOM._parser;
			}
		}

		// Token: 0x1700204A RID: 8266
		// (get) Token: 0x060072C8 RID: 29384 RVA: 0x00131AE0 File Offset: 0x0012FCE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LJFBDHHDPOMReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700204B RID: 8267
		// (get) Token: 0x060072C9 RID: 29385 RVA: 0x00131AF2 File Offset: 0x0012FCF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LJFBDHHDPOM.Descriptor;
			}
		}

		// Token: 0x060072CA RID: 29386 RVA: 0x00131AF9 File Offset: 0x0012FCF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LJFBDHHDPOM()
		{
		}

		// Token: 0x060072CB RID: 29387 RVA: 0x00131B04 File Offset: 0x0012FD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LJFBDHHDPOM(LJFBDHHDPOM other) : this()
		{
			this.gENPIDJKEFN_ = other.gENPIDJKEFN_;
			this.iNCEIHILNON_ = ((other.iNCEIHILNON_ != null) ? other.iNCEIHILNON_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060072CC RID: 29388 RVA: 0x00131B50 File Offset: 0x0012FD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LJFBDHHDPOM Clone()
		{
			return new LJFBDHHDPOM(this);
		}

		// Token: 0x1700204C RID: 8268
		// (get) Token: 0x060072CD RID: 29389 RVA: 0x00131B58 File Offset: 0x0012FD58
		// (set) Token: 0x060072CE RID: 29390 RVA: 0x00131B60 File Offset: 0x0012FD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GENPIDJKEFN
		{
			get
			{
				return this.gENPIDJKEFN_;
			}
			set
			{
				this.gENPIDJKEFN_ = value;
			}
		}

		// Token: 0x1700204D RID: 8269
		// (get) Token: 0x060072CF RID: 29391 RVA: 0x00131B69 File Offset: 0x0012FD69
		// (set) Token: 0x060072D0 RID: 29392 RVA: 0x00131B71 File Offset: 0x0012FD71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameRogueMiracle INCEIHILNON
		{
			get
			{
				return this.iNCEIHILNON_;
			}
			set
			{
				this.iNCEIHILNON_ = value;
			}
		}

		// Token: 0x060072D1 RID: 29393 RVA: 0x00131B7A File Offset: 0x0012FD7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LJFBDHHDPOM);
		}

		// Token: 0x060072D2 RID: 29394 RVA: 0x00131B88 File Offset: 0x0012FD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LJFBDHHDPOM other)
		{
			return other != null && (other == this || (this.GENPIDJKEFN == other.GENPIDJKEFN && object.Equals(this.INCEIHILNON, other.INCEIHILNON) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060072D3 RID: 29395 RVA: 0x00131BD8 File Offset: 0x0012FDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GENPIDJKEFN != 0U)
			{
				num ^= this.GENPIDJKEFN.GetHashCode();
			}
			if (this.iNCEIHILNON_ != null)
			{
				num ^= this.INCEIHILNON.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060072D4 RID: 29396 RVA: 0x00131C2D File Offset: 0x0012FE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060072D5 RID: 29397 RVA: 0x00131C35 File Offset: 0x0012FE35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060072D6 RID: 29398 RVA: 0x00131C40 File Offset: 0x0012FE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.iNCEIHILNON_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.INCEIHILNON);
			}
			if (this.GENPIDJKEFN != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.GENPIDJKEFN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060072D7 RID: 29399 RVA: 0x00131C9C File Offset: 0x0012FE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GENPIDJKEFN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GENPIDJKEFN);
			}
			if (this.iNCEIHILNON_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.INCEIHILNON);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060072D8 RID: 29400 RVA: 0x00131CF4 File Offset: 0x0012FEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LJFBDHHDPOM other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GENPIDJKEFN != 0U)
			{
				this.GENPIDJKEFN = other.GENPIDJKEFN;
			}
			if (other.iNCEIHILNON_ != null)
			{
				if (this.iNCEIHILNON_ == null)
				{
					this.INCEIHILNON = new GameRogueMiracle();
				}
				this.INCEIHILNON.MergeFrom(other.INCEIHILNON);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060072D9 RID: 29401 RVA: 0x00131D5C File Offset: 0x0012FF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060072DA RID: 29402 RVA: 0x00131D68 File Offset: 0x0012FF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GENPIDJKEFN = input.ReadUInt32();
					}
				}
				else
				{
					if (this.iNCEIHILNON_ == null)
					{
						this.INCEIHILNON = new GameRogueMiracle();
					}
					input.ReadMessage(this.INCEIHILNON);
				}
			}
		}

		// Token: 0x04002C2E RID: 11310
		private static readonly MessageParser<LJFBDHHDPOM> _parser = new MessageParser<LJFBDHHDPOM>(() => new LJFBDHHDPOM());

		// Token: 0x04002C2F RID: 11311
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C30 RID: 11312
		public const int GENPIDJKEFNFieldNumber = 14;

		// Token: 0x04002C31 RID: 11313
		private uint gENPIDJKEFN_;

		// Token: 0x04002C32 RID: 11314
		public const int INCEIHILNONFieldNumber = 9;

		// Token: 0x04002C33 RID: 11315
		private GameRogueMiracle iNCEIHILNON_;
	}
}
