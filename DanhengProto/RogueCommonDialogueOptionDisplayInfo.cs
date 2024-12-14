using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E49 RID: 3657
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonDialogueOptionDisplayInfo : IMessage<RogueCommonDialogueOptionDisplayInfo>, IMessage, IEquatable<RogueCommonDialogueOptionDisplayInfo>, IDeepCloneable<RogueCommonDialogueOptionDisplayInfo>, IBufferMessage
	{
		// Token: 0x17002E13 RID: 11795
		// (get) Token: 0x0600A321 RID: 41761 RVA: 0x001B6DE5 File Offset: 0x001B4FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonDialogueOptionDisplayInfo> Parser
		{
			get
			{
				return RogueCommonDialogueOptionDisplayInfo._parser;
			}
		}

		// Token: 0x17002E14 RID: 11796
		// (get) Token: 0x0600A322 RID: 41762 RVA: 0x001B6DEC File Offset: 0x001B4FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonDialogueOptionDisplayInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E15 RID: 11797
		// (get) Token: 0x0600A323 RID: 41763 RVA: 0x001B6DFE File Offset: 0x001B4FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonDialogueOptionDisplayInfo.Descriptor;
			}
		}

		// Token: 0x0600A324 RID: 41764 RVA: 0x001B6E05 File Offset: 0x001B5005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueOptionDisplayInfo()
		{
		}

		// Token: 0x0600A325 RID: 41765 RVA: 0x001B6E0D File Offset: 0x001B500D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueOptionDisplayInfo(RogueCommonDialogueOptionDisplayInfo other) : this()
		{
			this.displayIntValue_ = other.displayIntValue_;
			this.displayFloatValue_ = other.displayFloatValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A326 RID: 41766 RVA: 0x001B6E3E File Offset: 0x001B503E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueOptionDisplayInfo Clone()
		{
			return new RogueCommonDialogueOptionDisplayInfo(this);
		}

		// Token: 0x17002E16 RID: 11798
		// (get) Token: 0x0600A327 RID: 41767 RVA: 0x001B6E46 File Offset: 0x001B5046
		// (set) Token: 0x0600A328 RID: 41768 RVA: 0x001B6E4E File Offset: 0x001B504E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DisplayIntValue
		{
			get
			{
				return this.displayIntValue_;
			}
			set
			{
				this.displayIntValue_ = value;
			}
		}

		// Token: 0x17002E17 RID: 11799
		// (get) Token: 0x0600A329 RID: 41769 RVA: 0x001B6E57 File Offset: 0x001B5057
		// (set) Token: 0x0600A32A RID: 41770 RVA: 0x001B6E5F File Offset: 0x001B505F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float DisplayFloatValue
		{
			get
			{
				return this.displayFloatValue_;
			}
			set
			{
				this.displayFloatValue_ = value;
			}
		}

		// Token: 0x0600A32B RID: 41771 RVA: 0x001B6E68 File Offset: 0x001B5068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonDialogueOptionDisplayInfo);
		}

		// Token: 0x0600A32C RID: 41772 RVA: 0x001B6E78 File Offset: 0x001B5078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonDialogueOptionDisplayInfo other)
		{
			return other != null && (other == this || (this.DisplayIntValue == other.DisplayIntValue && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.DisplayFloatValue, other.DisplayFloatValue) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A32D RID: 41773 RVA: 0x001B6ECC File Offset: 0x001B50CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DisplayIntValue != 0)
			{
				num ^= this.DisplayIntValue.GetHashCode();
			}
			if (this.DisplayFloatValue != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.DisplayFloatValue);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A32E RID: 41774 RVA: 0x001B6F2B File Offset: 0x001B512B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A32F RID: 41775 RVA: 0x001B6F33 File Offset: 0x001B5133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A330 RID: 41776 RVA: 0x001B6F3C File Offset: 0x001B513C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DisplayFloatValue != 0f)
			{
				output.WriteRawTag(53);
				output.WriteFloat(this.DisplayFloatValue);
			}
			if (this.DisplayIntValue != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.DisplayIntValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A331 RID: 41777 RVA: 0x001B6F9C File Offset: 0x001B519C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DisplayIntValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DisplayIntValue);
			}
			if (this.DisplayFloatValue != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A332 RID: 41778 RVA: 0x001B6FEC File Offset: 0x001B51EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonDialogueOptionDisplayInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DisplayIntValue != 0)
			{
				this.DisplayIntValue = other.DisplayIntValue;
			}
			if (other.DisplayFloatValue != 0f)
			{
				this.DisplayFloatValue = other.DisplayFloatValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A333 RID: 41779 RVA: 0x001B7041 File Offset: 0x001B5241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A334 RID: 41780 RVA: 0x001B704C File Offset: 0x001B524C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 53U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.DisplayIntValue = input.ReadInt32();
					}
				}
				else
				{
					this.DisplayFloatValue = input.ReadFloat();
				}
			}
		}

		// Token: 0x040042D1 RID: 17105
		private static readonly MessageParser<RogueCommonDialogueOptionDisplayInfo> _parser = new MessageParser<RogueCommonDialogueOptionDisplayInfo>(() => new RogueCommonDialogueOptionDisplayInfo());

		// Token: 0x040042D2 RID: 17106
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042D3 RID: 17107
		public const int DisplayIntValueFieldNumber = 13;

		// Token: 0x040042D4 RID: 17108
		private int displayIntValue_;

		// Token: 0x040042D5 RID: 17109
		public const int DisplayFloatValueFieldNumber = 6;

		// Token: 0x040042D6 RID: 17110
		private float displayFloatValue_;
	}
}
