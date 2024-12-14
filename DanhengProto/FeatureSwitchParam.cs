using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000511 RID: 1297
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FeatureSwitchParam : IMessage<FeatureSwitchParam>, IMessage, IEquatable<FeatureSwitchParam>, IDeepCloneable<FeatureSwitchParam>, IBufferMessage
	{
		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x06003A23 RID: 14883 RVA: 0x0009FEE4 File Offset: 0x0009E0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FeatureSwitchParam> Parser
		{
			get
			{
				return FeatureSwitchParam._parser;
			}
		}

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x06003A24 RID: 14884 RVA: 0x0009FEEB File Offset: 0x0009E0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FeatureSwitchParamReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x06003A25 RID: 14885 RVA: 0x0009FEFD File Offset: 0x0009E0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FeatureSwitchParam.Descriptor;
			}
		}

		// Token: 0x06003A26 RID: 14886 RVA: 0x0009FF04 File Offset: 0x0009E104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeatureSwitchParam()
		{
		}

		// Token: 0x06003A27 RID: 14887 RVA: 0x0009FF17 File Offset: 0x0009E117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeatureSwitchParam(FeatureSwitchParam other) : this()
		{
			this.switchList_ = other.switchList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A28 RID: 14888 RVA: 0x0009FF41 File Offset: 0x0009E141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeatureSwitchParam Clone()
		{
			return new FeatureSwitchParam(this);
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x06003A29 RID: 14889 RVA: 0x0009FF49 File Offset: 0x0009E149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> SwitchList
		{
			get
			{
				return this.switchList_;
			}
		}

		// Token: 0x06003A2A RID: 14890 RVA: 0x0009FF51 File Offset: 0x0009E151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FeatureSwitchParam);
		}

		// Token: 0x06003A2B RID: 14891 RVA: 0x0009FF5F File Offset: 0x0009E15F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FeatureSwitchParam other)
		{
			return other != null && (other == this || (this.switchList_.Equals(other.switchList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x0009FF94 File Offset: 0x0009E194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.switchList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003A2D RID: 14893 RVA: 0x0009FFC8 File Offset: 0x0009E1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003A2E RID: 14894 RVA: 0x0009FFD0 File Offset: 0x0009E1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A2F RID: 14895 RVA: 0x0009FFD9 File Offset: 0x0009E1D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.switchList_.WriteTo(ref output, FeatureSwitchParam._repeated_switchList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A30 RID: 14896 RVA: 0x000A0000 File Offset: 0x0009E200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.switchList_.CalculateSize(FeatureSwitchParam._repeated_switchList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003A31 RID: 14897 RVA: 0x000A0039 File Offset: 0x0009E239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FeatureSwitchParam other)
		{
			if (other == null)
			{
				return;
			}
			this.switchList_.Add(other.switchList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003A32 RID: 14898 RVA: 0x000A0067 File Offset: 0x0009E267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A33 RID: 14899 RVA: 0x000A0070 File Offset: 0x0009E270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.switchList_.AddEntriesFrom(ref input, FeatureSwitchParam._repeated_switchList_codec);
				}
			}
		}

		// Token: 0x04001729 RID: 5929
		private static readonly MessageParser<FeatureSwitchParam> _parser = new MessageParser<FeatureSwitchParam>(() => new FeatureSwitchParam());

		// Token: 0x0400172A RID: 5930
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400172B RID: 5931
		public const int SwitchListFieldNumber = 1;

		// Token: 0x0400172C RID: 5932
		private static readonly FieldCodec<uint> _repeated_switchList_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x0400172D RID: 5933
		private readonly RepeatedField<uint> switchList_ = new RepeatedField<uint>();
	}
}
