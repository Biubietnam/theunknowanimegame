using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200039D RID: 925
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DifficultyAdjustmentGetDataScRsp : IMessage<DifficultyAdjustmentGetDataScRsp>, IMessage, IEquatable<DifficultyAdjustmentGetDataScRsp>, IDeepCloneable<DifficultyAdjustmentGetDataScRsp>, IBufferMessage
	{
		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06002923 RID: 10531 RVA: 0x0007268B File Offset: 0x0007088B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DifficultyAdjustmentGetDataScRsp> Parser
		{
			get
			{
				return DifficultyAdjustmentGetDataScRsp._parser;
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06002924 RID: 10532 RVA: 0x00072692 File Offset: 0x00070892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DifficultyAdjustmentGetDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06002925 RID: 10533 RVA: 0x000726A4 File Offset: 0x000708A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DifficultyAdjustmentGetDataScRsp.Descriptor;
			}
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x000726AB File Offset: 0x000708AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DifficultyAdjustmentGetDataScRsp()
		{
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x000726BE File Offset: 0x000708BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DifficultyAdjustmentGetDataScRsp(DifficultyAdjustmentGetDataScRsp other) : this()
		{
			this.contentPackageList_ = other.contentPackageList_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x000726F4 File Offset: 0x000708F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DifficultyAdjustmentGetDataScRsp Clone()
		{
			return new DifficultyAdjustmentGetDataScRsp(this);
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06002929 RID: 10537 RVA: 0x000726FC File Offset: 0x000708FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FPGKHIFENGL> ContentPackageList
		{
			get
			{
				return this.contentPackageList_;
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x0600292A RID: 10538 RVA: 0x00072704 File Offset: 0x00070904
		// (set) Token: 0x0600292B RID: 10539 RVA: 0x0007270C File Offset: 0x0007090C
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

		// Token: 0x0600292C RID: 10540 RVA: 0x00072715 File Offset: 0x00070915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DifficultyAdjustmentGetDataScRsp);
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x00072724 File Offset: 0x00070924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DifficultyAdjustmentGetDataScRsp other)
		{
			return other != null && (other == this || (this.contentPackageList_.Equals(other.contentPackageList_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x00072774 File Offset: 0x00070974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.contentPackageList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x000727C1 File Offset: 0x000709C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x000727C9 File Offset: 0x000709C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x000727D4 File Offset: 0x000709D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			this.contentPackageList_.WriteTo(ref output, DifficultyAdjustmentGetDataScRsp._repeated_contentPackageList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x00072824 File Offset: 0x00070A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.contentPackageList_.CalculateSize(DifficultyAdjustmentGetDataScRsp._repeated_contentPackageList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x00072878 File Offset: 0x00070A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DifficultyAdjustmentGetDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.contentPackageList_.Add(other.contentPackageList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x000728C5 File Offset: 0x00070AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x000728D0 File Offset: 0x00070AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.contentPackageList_.AddEntriesFrom(ref input, DifficultyAdjustmentGetDataScRsp._repeated_contentPackageList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001097 RID: 4247
		private static readonly MessageParser<DifficultyAdjustmentGetDataScRsp> _parser = new MessageParser<DifficultyAdjustmentGetDataScRsp>(() => new DifficultyAdjustmentGetDataScRsp());

		// Token: 0x04001098 RID: 4248
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001099 RID: 4249
		public const int ContentPackageListFieldNumber = 15;

		// Token: 0x0400109A RID: 4250
		private static readonly FieldCodec<FPGKHIFENGL> _repeated_contentPackageList_codec = FieldCodec.ForMessage<FPGKHIFENGL>(122U, FPGKHIFENGL.Parser);

		// Token: 0x0400109B RID: 4251
		private readonly RepeatedField<FPGKHIFENGL> contentPackageList_ = new RepeatedField<FPGKHIFENGL>();

		// Token: 0x0400109C RID: 4252
		public const int RetcodeFieldNumber = 5;

		// Token: 0x0400109D RID: 4253
		private uint retcode_;
	}
}
