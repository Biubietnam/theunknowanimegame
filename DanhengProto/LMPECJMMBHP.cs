using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A27 RID: 2599
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LMPECJMMBHP : IMessage<LMPECJMMBHP>, IMessage, IEquatable<LMPECJMMBHP>, IDeepCloneable<LMPECJMMBHP>, IBufferMessage
	{
		// Token: 0x17002079 RID: 8313
		// (get) Token: 0x0600737B RID: 29563 RVA: 0x00133494 File Offset: 0x00131694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LMPECJMMBHP> Parser
		{
			get
			{
				return LMPECJMMBHP._parser;
			}
		}

		// Token: 0x1700207A RID: 8314
		// (get) Token: 0x0600737C RID: 29564 RVA: 0x0013349B File Offset: 0x0013169B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LMPECJMMBHPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700207B RID: 8315
		// (get) Token: 0x0600737D RID: 29565 RVA: 0x001334AD File Offset: 0x001316AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LMPECJMMBHP.Descriptor;
			}
		}

		// Token: 0x0600737E RID: 29566 RVA: 0x001334B4 File Offset: 0x001316B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMPECJMMBHP()
		{
		}

		// Token: 0x0600737F RID: 29567 RVA: 0x001334BC File Offset: 0x001316BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMPECJMMBHP(LMPECJMMBHP other) : this()
		{
			this.eJFDJKBGLPA_ = other.eJFDJKBGLPA_;
			this.pLFPJDMGBBN_ = other.pLFPJDMGBBN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007380 RID: 29568 RVA: 0x001334ED File Offset: 0x001316ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMPECJMMBHP Clone()
		{
			return new LMPECJMMBHP(this);
		}

		// Token: 0x1700207C RID: 8316
		// (get) Token: 0x06007381 RID: 29569 RVA: 0x001334F5 File Offset: 0x001316F5
		// (set) Token: 0x06007382 RID: 29570 RVA: 0x001334FD File Offset: 0x001316FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EJFDJKBGLPA
		{
			get
			{
				return this.eJFDJKBGLPA_;
			}
			set
			{
				this.eJFDJKBGLPA_ = value;
			}
		}

		// Token: 0x1700207D RID: 8317
		// (get) Token: 0x06007383 RID: 29571 RVA: 0x00133506 File Offset: 0x00131706
		// (set) Token: 0x06007384 RID: 29572 RVA: 0x0013350E File Offset: 0x0013170E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PLFPJDMGBBN
		{
			get
			{
				return this.pLFPJDMGBBN_;
			}
			set
			{
				this.pLFPJDMGBBN_ = value;
			}
		}

		// Token: 0x06007385 RID: 29573 RVA: 0x00133517 File Offset: 0x00131717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LMPECJMMBHP);
		}

		// Token: 0x06007386 RID: 29574 RVA: 0x00133525 File Offset: 0x00131725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LMPECJMMBHP other)
		{
			return other != null && (other == this || (this.EJFDJKBGLPA == other.EJFDJKBGLPA && this.PLFPJDMGBBN == other.PLFPJDMGBBN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007387 RID: 29575 RVA: 0x00133564 File Offset: 0x00131764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EJFDJKBGLPA != 0U)
			{
				num ^= this.EJFDJKBGLPA.GetHashCode();
			}
			if (this.PLFPJDMGBBN)
			{
				num ^= this.PLFPJDMGBBN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007388 RID: 29576 RVA: 0x001335BC File Offset: 0x001317BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007389 RID: 29577 RVA: 0x001335C4 File Offset: 0x001317C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600738A RID: 29578 RVA: 0x001335D0 File Offset: 0x001317D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PLFPJDMGBBN)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.PLFPJDMGBBN);
			}
			if (this.EJFDJKBGLPA != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.EJFDJKBGLPA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600738B RID: 29579 RVA: 0x0013362C File Offset: 0x0013182C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EJFDJKBGLPA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EJFDJKBGLPA);
			}
			if (this.PLFPJDMGBBN)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600738C RID: 29580 RVA: 0x00133678 File Offset: 0x00131878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LMPECJMMBHP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EJFDJKBGLPA != 0U)
			{
				this.EJFDJKBGLPA = other.EJFDJKBGLPA;
			}
			if (other.PLFPJDMGBBN)
			{
				this.PLFPJDMGBBN = other.PLFPJDMGBBN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600738D RID: 29581 RVA: 0x001336C8 File Offset: 0x001318C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600738E RID: 29582 RVA: 0x001336D4 File Offset: 0x001318D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EJFDJKBGLPA = input.ReadUInt32();
					}
				}
				else
				{
					this.PLFPJDMGBBN = input.ReadBool();
				}
			}
		}

		// Token: 0x04002C6A RID: 11370
		private static readonly MessageParser<LMPECJMMBHP> _parser = new MessageParser<LMPECJMMBHP>(() => new LMPECJMMBHP());

		// Token: 0x04002C6B RID: 11371
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C6C RID: 11372
		public const int EJFDJKBGLPAFieldNumber = 15;

		// Token: 0x04002C6D RID: 11373
		private uint eJFDJKBGLPA_;

		// Token: 0x04002C6E RID: 11374
		public const int PLFPJDMGBBNFieldNumber = 4;

		// Token: 0x04002C6F RID: 11375
		private bool pLFPJDMGBBN_;
	}
}
