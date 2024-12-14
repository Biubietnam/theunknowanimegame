using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001359 RID: 4953
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TextJoinSaveCsReq : IMessage<TextJoinSaveCsReq>, IMessage, IEquatable<TextJoinSaveCsReq>, IDeepCloneable<TextJoinSaveCsReq>, IBufferMessage
	{
		// Token: 0x17003E16 RID: 15894
		// (get) Token: 0x0600DD0D RID: 56589 RVA: 0x0024C7D5 File Offset: 0x0024A9D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TextJoinSaveCsReq> Parser
		{
			get
			{
				return TextJoinSaveCsReq._parser;
			}
		}

		// Token: 0x17003E17 RID: 15895
		// (get) Token: 0x0600DD0E RID: 56590 RVA: 0x0024C7DC File Offset: 0x0024A9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TextJoinSaveCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E18 RID: 15896
		// (get) Token: 0x0600DD0F RID: 56591 RVA: 0x0024C7EE File Offset: 0x0024A9EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TextJoinSaveCsReq.Descriptor;
			}
		}

		// Token: 0x0600DD10 RID: 56592 RVA: 0x0024C7F5 File Offset: 0x0024A9F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TextJoinSaveCsReq()
		{
		}

		// Token: 0x0600DD11 RID: 56593 RVA: 0x0024C808 File Offset: 0x0024AA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TextJoinSaveCsReq(TextJoinSaveCsReq other) : this()
		{
			this.textItemConfigId_ = other.textItemConfigId_;
			this.aINAOENMOME_ = other.aINAOENMOME_;
			this.textItemId_ = other.textItemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD12 RID: 56594 RVA: 0x0024C845 File Offset: 0x0024AA45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TextJoinSaveCsReq Clone()
		{
			return new TextJoinSaveCsReq(this);
		}

		// Token: 0x17003E19 RID: 15897
		// (get) Token: 0x0600DD13 RID: 56595 RVA: 0x0024C84D File Offset: 0x0024AA4D
		// (set) Token: 0x0600DD14 RID: 56596 RVA: 0x0024C855 File Offset: 0x0024AA55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TextItemConfigId
		{
			get
			{
				return this.textItemConfigId_;
			}
			set
			{
				this.textItemConfigId_ = value;
			}
		}

		// Token: 0x17003E1A RID: 15898
		// (get) Token: 0x0600DD15 RID: 56597 RVA: 0x0024C85E File Offset: 0x0024AA5E
		// (set) Token: 0x0600DD16 RID: 56598 RVA: 0x0024C866 File Offset: 0x0024AA66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AINAOENMOME
		{
			get
			{
				return this.aINAOENMOME_;
			}
			set
			{
				this.aINAOENMOME_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003E1B RID: 15899
		// (get) Token: 0x0600DD17 RID: 56599 RVA: 0x0024C879 File Offset: 0x0024AA79
		// (set) Token: 0x0600DD18 RID: 56600 RVA: 0x0024C881 File Offset: 0x0024AA81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TextItemId
		{
			get
			{
				return this.textItemId_;
			}
			set
			{
				this.textItemId_ = value;
			}
		}

		// Token: 0x0600DD19 RID: 56601 RVA: 0x0024C88A File Offset: 0x0024AA8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TextJoinSaveCsReq);
		}

		// Token: 0x0600DD1A RID: 56602 RVA: 0x0024C898 File Offset: 0x0024AA98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TextJoinSaveCsReq other)
		{
			return other != null && (other == this || (this.TextItemConfigId == other.TextItemConfigId && !(this.AINAOENMOME != other.AINAOENMOME) && this.TextItemId == other.TextItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD1B RID: 56603 RVA: 0x0024C8F8 File Offset: 0x0024AAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TextItemConfigId != 0U)
			{
				num ^= this.TextItemConfigId.GetHashCode();
			}
			if (this.AINAOENMOME.Length != 0)
			{
				num ^= this.AINAOENMOME.GetHashCode();
			}
			if (this.TextItemId != 0U)
			{
				num ^= this.TextItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DD1C RID: 56604 RVA: 0x0024C96B File Offset: 0x0024AB6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DD1D RID: 56605 RVA: 0x0024C973 File Offset: 0x0024AB73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD1E RID: 56606 RVA: 0x0024C97C File Offset: 0x0024AB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TextItemConfigId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.TextItemConfigId);
			}
			if (this.AINAOENMOME.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.AINAOENMOME);
			}
			if (this.TextItemId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.TextItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD1F RID: 56607 RVA: 0x0024C9F8 File Offset: 0x0024ABF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TextItemConfigId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TextItemConfigId);
			}
			if (this.AINAOENMOME.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AINAOENMOME);
			}
			if (this.TextItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TextItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DD20 RID: 56608 RVA: 0x0024CA6C File Offset: 0x0024AC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TextJoinSaveCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TextItemConfigId != 0U)
			{
				this.TextItemConfigId = other.TextItemConfigId;
			}
			if (other.AINAOENMOME.Length != 0)
			{
				this.AINAOENMOME = other.AINAOENMOME;
			}
			if (other.TextItemId != 0U)
			{
				this.TextItemId = other.TextItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DD21 RID: 56609 RVA: 0x0024CAD5 File Offset: 0x0024ACD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD22 RID: 56610 RVA: 0x0024CAE0 File Offset: 0x0024ACE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 50U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TextItemId = input.ReadUInt32();
						}
					}
					else
					{
						this.AINAOENMOME = input.ReadString();
					}
				}
				else
				{
					this.TextItemConfigId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040057EB RID: 22507
		private static readonly MessageParser<TextJoinSaveCsReq> _parser = new MessageParser<TextJoinSaveCsReq>(() => new TextJoinSaveCsReq());

		// Token: 0x040057EC RID: 22508
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057ED RID: 22509
		public const int TextItemConfigIdFieldNumber = 2;

		// Token: 0x040057EE RID: 22510
		private uint textItemConfigId_;

		// Token: 0x040057EF RID: 22511
		public const int AINAOENMOMEFieldNumber = 6;

		// Token: 0x040057F0 RID: 22512
		private string aINAOENMOME_ = "";

		// Token: 0x040057F1 RID: 22513
		public const int TextItemIdFieldNumber = 12;

		// Token: 0x040057F2 RID: 22514
		private uint textItemId_;
	}
}
