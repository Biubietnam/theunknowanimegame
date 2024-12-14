using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003A3 RID: 931
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DifficultyAdjustmentUpdateDataScRsp : IMessage<DifficultyAdjustmentUpdateDataScRsp>, IMessage, IEquatable<DifficultyAdjustmentUpdateDataScRsp>, IDeepCloneable<DifficultyAdjustmentUpdateDataScRsp>, IBufferMessage
	{
		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06002950 RID: 10576 RVA: 0x00072D27 File Offset: 0x00070F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DifficultyAdjustmentUpdateDataScRsp> Parser
		{
			get
			{
				return DifficultyAdjustmentUpdateDataScRsp._parser;
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06002951 RID: 10577 RVA: 0x00072D2E File Offset: 0x00070F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DifficultyAdjustmentUpdateDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06002952 RID: 10578 RVA: 0x00072D40 File Offset: 0x00070F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DifficultyAdjustmentUpdateDataScRsp.Descriptor;
			}
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x00072D47 File Offset: 0x00070F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DifficultyAdjustmentUpdateDataScRsp()
		{
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x00072D5C File Offset: 0x00070F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DifficultyAdjustmentUpdateDataScRsp(DifficultyAdjustmentUpdateDataScRsp other) : this()
		{
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.contentPackageList_ = other.contentPackageList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x00072DB9 File Offset: 0x00070FB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DifficultyAdjustmentUpdateDataScRsp Clone()
		{
			return new DifficultyAdjustmentUpdateDataScRsp(this);
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06002956 RID: 10582 RVA: 0x00072DC1 File Offset: 0x00070FC1
		// (set) Token: 0x06002957 RID: 10583 RVA: 0x00072DC9 File Offset: 0x00070FC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FPGKHIFENGL Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = value;
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06002958 RID: 10584 RVA: 0x00072DD2 File Offset: 0x00070FD2
		// (set) Token: 0x06002959 RID: 10585 RVA: 0x00072DDA File Offset: 0x00070FDA
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

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x0600295A RID: 10586 RVA: 0x00072DE3 File Offset: 0x00070FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FPGKHIFENGL> ContentPackageList
		{
			get
			{
				return this.contentPackageList_;
			}
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x00072DEB File Offset: 0x00070FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DifficultyAdjustmentUpdateDataScRsp);
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x00072DFC File Offset: 0x00070FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DifficultyAdjustmentUpdateDataScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Data, other.Data) && this.Retcode == other.Retcode && this.contentPackageList_.Equals(other.contentPackageList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x00072E60 File Offset: 0x00071060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.data_ != null)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.contentPackageList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x00072EC3 File Offset: 0x000710C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x00072ECB File Offset: 0x000710CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x00072ED4 File Offset: 0x000710D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			this.contentPackageList_.WriteTo(ref output, DifficultyAdjustmentUpdateDataScRsp._repeated_contentPackageList_codec);
			if (this.data_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x00072F40 File Offset: 0x00071140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.data_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Data);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.contentPackageList_.CalculateSize(DifficultyAdjustmentUpdateDataScRsp._repeated_contentPackageList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x00072FAC File Offset: 0x000711AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DifficultyAdjustmentUpdateDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.data_ != null)
			{
				if (this.data_ == null)
				{
					this.Data = new FPGKHIFENGL();
				}
				this.Data.MergeFrom(other.Data);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.contentPackageList_.Add(other.contentPackageList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x00073025 File Offset: 0x00071225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x00073030 File Offset: 0x00071230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 58U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.data_ == null)
							{
								this.Data = new FPGKHIFENGL();
							}
							input.ReadMessage(this.Data);
						}
					}
					else
					{
						this.contentPackageList_.AddEntriesFrom(ref input, DifficultyAdjustmentUpdateDataScRsp._repeated_contentPackageList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040010A8 RID: 4264
		private static readonly MessageParser<DifficultyAdjustmentUpdateDataScRsp> _parser = new MessageParser<DifficultyAdjustmentUpdateDataScRsp>(() => new DifficultyAdjustmentUpdateDataScRsp());

		// Token: 0x040010A9 RID: 4265
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010AA RID: 4266
		public const int DataFieldNumber = 15;

		// Token: 0x040010AB RID: 4267
		private FPGKHIFENGL data_;

		// Token: 0x040010AC RID: 4268
		public const int RetcodeFieldNumber = 2;

		// Token: 0x040010AD RID: 4269
		private uint retcode_;

		// Token: 0x040010AE RID: 4270
		public const int ContentPackageListFieldNumber = 7;

		// Token: 0x040010AF RID: 4271
		private static readonly FieldCodec<FPGKHIFENGL> _repeated_contentPackageList_codec = FieldCodec.ForMessage<FPGKHIFENGL>(58U, FPGKHIFENGL.Parser);

		// Token: 0x040010B0 RID: 4272
		private readonly RepeatedField<FPGKHIFENGL> contentPackageList_ = new RepeatedField<FPGKHIFENGL>();
	}
}
