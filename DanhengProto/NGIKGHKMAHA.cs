using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C17 RID: 3095
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NGIKGHKMAHA : IMessage<NGIKGHKMAHA>, IMessage, IEquatable<NGIKGHKMAHA>, IDeepCloneable<NGIKGHKMAHA>, IBufferMessage
	{
		// Token: 0x17002670 RID: 9840
		// (get) Token: 0x0600890A RID: 35082 RVA: 0x00169BE0 File Offset: 0x00167DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NGIKGHKMAHA> Parser
		{
			get
			{
				return NGIKGHKMAHA._parser;
			}
		}

		// Token: 0x17002671 RID: 9841
		// (get) Token: 0x0600890B RID: 35083 RVA: 0x00169BE7 File Offset: 0x00167DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NGIKGHKMAHAReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002672 RID: 9842
		// (get) Token: 0x0600890C RID: 35084 RVA: 0x00169BF9 File Offset: 0x00167DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NGIKGHKMAHA.Descriptor;
			}
		}

		// Token: 0x0600890D RID: 35085 RVA: 0x00169C00 File Offset: 0x00167E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NGIKGHKMAHA()
		{
		}

		// Token: 0x0600890E RID: 35086 RVA: 0x00169C08 File Offset: 0x00167E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NGIKGHKMAHA(NGIKGHKMAHA other) : this()
		{
			this.bAKMMJGDPMG_ = other.bAKMMJGDPMG_;
			this.fAMGMPJOIKD_ = other.fAMGMPJOIKD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600890F RID: 35087 RVA: 0x00169C39 File Offset: 0x00167E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NGIKGHKMAHA Clone()
		{
			return new NGIKGHKMAHA(this);
		}

		// Token: 0x17002673 RID: 9843
		// (get) Token: 0x06008910 RID: 35088 RVA: 0x00169C41 File Offset: 0x00167E41
		// (set) Token: 0x06008911 RID: 35089 RVA: 0x00169C49 File Offset: 0x00167E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BAKMMJGDPMG
		{
			get
			{
				return this.bAKMMJGDPMG_;
			}
			set
			{
				this.bAKMMJGDPMG_ = value;
			}
		}

		// Token: 0x17002674 RID: 9844
		// (get) Token: 0x06008912 RID: 35090 RVA: 0x00169C52 File Offset: 0x00167E52
		// (set) Token: 0x06008913 RID: 35091 RVA: 0x00169C5A File Offset: 0x00167E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FAMGMPJOIKD
		{
			get
			{
				return this.fAMGMPJOIKD_;
			}
			set
			{
				this.fAMGMPJOIKD_ = value;
			}
		}

		// Token: 0x06008914 RID: 35092 RVA: 0x00169C63 File Offset: 0x00167E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NGIKGHKMAHA);
		}

		// Token: 0x06008915 RID: 35093 RVA: 0x00169C71 File Offset: 0x00167E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NGIKGHKMAHA other)
		{
			return other != null && (other == this || (this.BAKMMJGDPMG == other.BAKMMJGDPMG && this.FAMGMPJOIKD == other.FAMGMPJOIKD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008916 RID: 35094 RVA: 0x00169CB0 File Offset: 0x00167EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BAKMMJGDPMG != 0U)
			{
				num ^= this.BAKMMJGDPMG.GetHashCode();
			}
			if (this.FAMGMPJOIKD != 0U)
			{
				num ^= this.FAMGMPJOIKD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008917 RID: 35095 RVA: 0x00169D08 File Offset: 0x00167F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008918 RID: 35096 RVA: 0x00169D10 File Offset: 0x00167F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008919 RID: 35097 RVA: 0x00169D1C File Offset: 0x00167F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BAKMMJGDPMG != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.BAKMMJGDPMG);
			}
			if (this.FAMGMPJOIKD != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.FAMGMPJOIKD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600891A RID: 35098 RVA: 0x00169D74 File Offset: 0x00167F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BAKMMJGDPMG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BAKMMJGDPMG);
			}
			if (this.FAMGMPJOIKD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FAMGMPJOIKD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600891B RID: 35099 RVA: 0x00169DCC File Offset: 0x00167FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NGIKGHKMAHA other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BAKMMJGDPMG != 0U)
			{
				this.BAKMMJGDPMG = other.BAKMMJGDPMG;
			}
			if (other.FAMGMPJOIKD != 0U)
			{
				this.FAMGMPJOIKD = other.FAMGMPJOIKD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600891C RID: 35100 RVA: 0x00169E1C File Offset: 0x0016801C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600891D RID: 35101 RVA: 0x00169E28 File Offset: 0x00168028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FAMGMPJOIKD = input.ReadUInt32();
					}
				}
				else
				{
					this.BAKMMJGDPMG = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003482 RID: 13442
		private static readonly MessageParser<NGIKGHKMAHA> _parser = new MessageParser<NGIKGHKMAHA>(() => new NGIKGHKMAHA());

		// Token: 0x04003483 RID: 13443
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003484 RID: 13444
		public const int BAKMMJGDPMGFieldNumber = 1;

		// Token: 0x04003485 RID: 13445
		private uint bAKMMJGDPMG_;

		// Token: 0x04003486 RID: 13446
		public const int FAMGMPJOIKDFieldNumber = 2;

		// Token: 0x04003487 RID: 13447
		private uint fAMGMPJOIKD_;
	}
}
