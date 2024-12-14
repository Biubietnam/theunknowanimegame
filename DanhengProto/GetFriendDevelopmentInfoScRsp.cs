using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006C7 RID: 1735
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFriendDevelopmentInfoScRsp : IMessage<GetFriendDevelopmentInfoScRsp>, IMessage, IEquatable<GetFriendDevelopmentInfoScRsp>, IDeepCloneable<GetFriendDevelopmentInfoScRsp>, IBufferMessage
	{
		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x06004DA6 RID: 19878 RVA: 0x000D262B File Offset: 0x000D082B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFriendDevelopmentInfoScRsp> Parser
		{
			get
			{
				return GetFriendDevelopmentInfoScRsp._parser;
			}
		}

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x06004DA7 RID: 19879 RVA: 0x000D2632 File Offset: 0x000D0832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFriendDevelopmentInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x06004DA8 RID: 19880 RVA: 0x000D2644 File Offset: 0x000D0844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFriendDevelopmentInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06004DA9 RID: 19881 RVA: 0x000D264B File Offset: 0x000D084B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendDevelopmentInfoScRsp()
		{
		}

		// Token: 0x06004DAA RID: 19882 RVA: 0x000D2660 File Offset: 0x000D0860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendDevelopmentInfoScRsp(GetFriendDevelopmentInfoScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.uid_ = other.uid_;
			this.oIMBMGNNNBM_ = other.oIMBMGNNNBM_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004DAB RID: 19883 RVA: 0x000D26AD File Offset: 0x000D08AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendDevelopmentInfoScRsp Clone()
		{
			return new GetFriendDevelopmentInfoScRsp(this);
		}

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x06004DAC RID: 19884 RVA: 0x000D26B5 File Offset: 0x000D08B5
		// (set) Token: 0x06004DAD RID: 19885 RVA: 0x000D26BD File Offset: 0x000D08BD
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

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x06004DAE RID: 19886 RVA: 0x000D26C6 File Offset: 0x000D08C6
		// (set) Token: 0x06004DAF RID: 19887 RVA: 0x000D26CE File Offset: 0x000D08CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x06004DB0 RID: 19888 RVA: 0x000D26D7 File Offset: 0x000D08D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FAINMOBPJMG> OIMBMGNNNBM
		{
			get
			{
				return this.oIMBMGNNNBM_;
			}
		}

		// Token: 0x06004DB1 RID: 19889 RVA: 0x000D26DF File Offset: 0x000D08DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFriendDevelopmentInfoScRsp);
		}

		// Token: 0x06004DB2 RID: 19890 RVA: 0x000D26F0 File Offset: 0x000D08F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFriendDevelopmentInfoScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.Uid == other.Uid && this.oIMBMGNNNBM_.Equals(other.oIMBMGNNNBM_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004DB3 RID: 19891 RVA: 0x000D2750 File Offset: 0x000D0950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			num ^= this.oIMBMGNNNBM_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004DB4 RID: 19892 RVA: 0x000D27B6 File Offset: 0x000D09B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004DB5 RID: 19893 RVA: 0x000D27BE File Offset: 0x000D09BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004DB6 RID: 19894 RVA: 0x000D27C8 File Offset: 0x000D09C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Uid);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			this.oIMBMGNNNBM_.WriteTo(ref output, GetFriendDevelopmentInfoScRsp._repeated_oIMBMGNNNBM_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004DB7 RID: 19895 RVA: 0x000D2834 File Offset: 0x000D0A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			num += this.oIMBMGNNNBM_.CalculateSize(GetFriendDevelopmentInfoScRsp._repeated_oIMBMGNNNBM_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004DB8 RID: 19896 RVA: 0x000D28A0 File Offset: 0x000D0AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFriendDevelopmentInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			this.oIMBMGNNNBM_.Add(other.oIMBMGNNNBM_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004DB9 RID: 19897 RVA: 0x000D2901 File Offset: 0x000D0B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004DBA RID: 19898 RVA: 0x000D290C File Offset: 0x000D0B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 80U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.oIMBMGNNNBM_.AddEntriesFrom(ref input, GetFriendDevelopmentInfoScRsp._repeated_oIMBMGNNNBM_codec);
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.Uid = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001EB2 RID: 7858
		private static readonly MessageParser<GetFriendDevelopmentInfoScRsp> _parser = new MessageParser<GetFriendDevelopmentInfoScRsp>(() => new GetFriendDevelopmentInfoScRsp());

		// Token: 0x04001EB3 RID: 7859
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001EB4 RID: 7860
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04001EB5 RID: 7861
		private uint retcode_;

		// Token: 0x04001EB6 RID: 7862
		public const int UidFieldNumber = 7;

		// Token: 0x04001EB7 RID: 7863
		private uint uid_;

		// Token: 0x04001EB8 RID: 7864
		public const int OIMBMGNNNBMFieldNumber = 15;

		// Token: 0x04001EB9 RID: 7865
		private static readonly FieldCodec<FAINMOBPJMG> _repeated_oIMBMGNNNBM_codec = FieldCodec.ForMessage<FAINMOBPJMG>(122U, FAINMOBPJMG.Parser);

		// Token: 0x04001EBA RID: 7866
		private readonly RepeatedField<FAINMOBPJMG> oIMBMGNNNBM_ = new RepeatedField<FAINMOBPJMG>();
	}
}
