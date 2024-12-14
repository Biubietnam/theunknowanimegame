using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200050F RID: 1295
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FeatureSwitchInfo : IMessage<FeatureSwitchInfo>, IMessage, IEquatable<FeatureSwitchInfo>, IDeepCloneable<FeatureSwitchInfo>, IBufferMessage
	{
		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x06003A0B RID: 14859 RVA: 0x0009FAFF File Offset: 0x0009DCFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FeatureSwitchInfo> Parser
		{
			get
			{
				return FeatureSwitchInfo._parser;
			}
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x06003A0C RID: 14860 RVA: 0x0009FB06 File Offset: 0x0009DD06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FeatureSwitchInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x06003A0D RID: 14861 RVA: 0x0009FB18 File Offset: 0x0009DD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FeatureSwitchInfo.Descriptor;
			}
		}

		// Token: 0x06003A0E RID: 14862 RVA: 0x0009FB1F File Offset: 0x0009DD1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeatureSwitchInfo()
		{
		}

		// Token: 0x06003A0F RID: 14863 RVA: 0x0009FB34 File Offset: 0x0009DD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeatureSwitchInfo(FeatureSwitchInfo other) : this()
		{
			this.type_ = other.type_;
			this.switchList_ = other.switchList_.Clone();
			this.isAllClosed_ = other.isAllClosed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A10 RID: 14864 RVA: 0x0009FB81 File Offset: 0x0009DD81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeatureSwitchInfo Clone()
		{
			return new FeatureSwitchInfo(this);
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x06003A11 RID: 14865 RVA: 0x0009FB89 File Offset: 0x0009DD89
		// (set) Token: 0x06003A12 RID: 14866 RVA: 0x0009FB91 File Offset: 0x0009DD91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeatureSwitchType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x06003A13 RID: 14867 RVA: 0x0009FB9A File Offset: 0x0009DD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FeatureSwitchParam> SwitchList
		{
			get
			{
				return this.switchList_;
			}
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x06003A14 RID: 14868 RVA: 0x0009FBA2 File Offset: 0x0009DDA2
		// (set) Token: 0x06003A15 RID: 14869 RVA: 0x0009FBAA File Offset: 0x0009DDAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAllClosed
		{
			get
			{
				return this.isAllClosed_;
			}
			set
			{
				this.isAllClosed_ = value;
			}
		}

		// Token: 0x06003A16 RID: 14870 RVA: 0x0009FBB3 File Offset: 0x0009DDB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FeatureSwitchInfo);
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x0009FBC4 File Offset: 0x0009DDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FeatureSwitchInfo other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.switchList_.Equals(other.switchList_) && this.IsAllClosed == other.IsAllClosed && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003A18 RID: 14872 RVA: 0x0009FC24 File Offset: 0x0009DE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != FeatureSwitchType.FeatureSwitchNone)
			{
				num ^= this.Type.GetHashCode();
			}
			num ^= this.switchList_.GetHashCode();
			if (this.IsAllClosed)
			{
				num ^= this.IsAllClosed.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003A19 RID: 14873 RVA: 0x0009FC90 File Offset: 0x0009DE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003A1A RID: 14874 RVA: 0x0009FC98 File Offset: 0x0009DE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A1B RID: 14875 RVA: 0x0009FCA4 File Offset: 0x0009DEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != FeatureSwitchType.FeatureSwitchNone)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			this.switchList_.WriteTo(ref output, FeatureSwitchInfo._repeated_switchList_codec);
			if (this.IsAllClosed)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsAllClosed);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A1C RID: 14876 RVA: 0x0009FD10 File Offset: 0x0009DF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != FeatureSwitchType.FeatureSwitchNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			num += this.switchList_.CalculateSize(FeatureSwitchInfo._repeated_switchList_codec);
			if (this.IsAllClosed)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x0009FD70 File Offset: 0x0009DF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FeatureSwitchInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != FeatureSwitchType.FeatureSwitchNone)
			{
				this.Type = other.Type;
			}
			this.switchList_.Add(other.switchList_);
			if (other.IsAllClosed)
			{
				this.IsAllClosed = other.IsAllClosed;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x0009FDD1 File Offset: 0x0009DFD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x0009FDDC File Offset: 0x0009DFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 18U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsAllClosed = input.ReadBool();
						}
					}
					else
					{
						this.switchList_.AddEntriesFrom(ref input, FeatureSwitchInfo._repeated_switchList_codec);
					}
				}
				else
				{
					this.Type = (FeatureSwitchType)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400171F RID: 5919
		private static readonly MessageParser<FeatureSwitchInfo> _parser = new MessageParser<FeatureSwitchInfo>(() => new FeatureSwitchInfo());

		// Token: 0x04001720 RID: 5920
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001721 RID: 5921
		public const int TypeFieldNumber = 1;

		// Token: 0x04001722 RID: 5922
		private FeatureSwitchType type_;

		// Token: 0x04001723 RID: 5923
		public const int SwitchListFieldNumber = 2;

		// Token: 0x04001724 RID: 5924
		private static readonly FieldCodec<FeatureSwitchParam> _repeated_switchList_codec = FieldCodec.ForMessage<FeatureSwitchParam>(18U, FeatureSwitchParam.Parser);

		// Token: 0x04001725 RID: 5925
		private readonly RepeatedField<FeatureSwitchParam> switchList_ = new RepeatedField<FeatureSwitchParam>();

		// Token: 0x04001726 RID: 5926
		public const int IsAllClosedFieldNumber = 3;

		// Token: 0x04001727 RID: 5927
		private bool isAllClosed_;
	}
}
