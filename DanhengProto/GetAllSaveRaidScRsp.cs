using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000611 RID: 1553
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAllSaveRaidScRsp : IMessage<GetAllSaveRaidScRsp>, IMessage, IEquatable<GetAllSaveRaidScRsp>, IDeepCloneable<GetAllSaveRaidScRsp>, IBufferMessage
	{
		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x060045A7 RID: 17831 RVA: 0x000BEF9D File Offset: 0x000BD19D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAllSaveRaidScRsp> Parser
		{
			get
			{
				return GetAllSaveRaidScRsp._parser;
			}
		}

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x060045A8 RID: 17832 RVA: 0x000BEFA4 File Offset: 0x000BD1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAllSaveRaidScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x060045A9 RID: 17833 RVA: 0x000BEFB6 File Offset: 0x000BD1B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAllSaveRaidScRsp.Descriptor;
			}
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x000BEFBD File Offset: 0x000BD1BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllSaveRaidScRsp()
		{
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x000BEFD0 File Offset: 0x000BD1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllSaveRaidScRsp(GetAllSaveRaidScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.raidDataList_ = other.raidDataList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060045AC RID: 17836 RVA: 0x000BF006 File Offset: 0x000BD206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAllSaveRaidScRsp Clone()
		{
			return new GetAllSaveRaidScRsp(this);
		}

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x060045AD RID: 17837 RVA: 0x000BF00E File Offset: 0x000BD20E
		// (set) Token: 0x060045AE RID: 17838 RVA: 0x000BF016 File Offset: 0x000BD216
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

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x060045AF RID: 17839 RVA: 0x000BF01F File Offset: 0x000BD21F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RaidData> RaidDataList
		{
			get
			{
				return this.raidDataList_;
			}
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x000BF027 File Offset: 0x000BD227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAllSaveRaidScRsp);
		}

		// Token: 0x060045B1 RID: 17841 RVA: 0x000BF038 File Offset: 0x000BD238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAllSaveRaidScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.raidDataList_.Equals(other.raidDataList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x000BF088 File Offset: 0x000BD288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.raidDataList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x000BF0D5 File Offset: 0x000BD2D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x000BF0DD File Offset: 0x000BD2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060045B5 RID: 17845 RVA: 0x000BF0E8 File Offset: 0x000BD2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.raidDataList_.WriteTo(ref output, GetAllSaveRaidScRsp._repeated_raidDataList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060045B6 RID: 17846 RVA: 0x000BF138 File Offset: 0x000BD338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.raidDataList_.CalculateSize(GetAllSaveRaidScRsp._repeated_raidDataList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060045B7 RID: 17847 RVA: 0x000BF18C File Offset: 0x000BD38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAllSaveRaidScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.raidDataList_.Add(other.raidDataList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x000BF1D9 File Offset: 0x000BD3D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x000BF1E4 File Offset: 0x000BD3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.raidDataList_.AddEntriesFrom(ref input, GetAllSaveRaidScRsp._repeated_raidDataList_codec);
				}
			}
		}

		// Token: 0x04001BE2 RID: 7138
		private static readonly MessageParser<GetAllSaveRaidScRsp> _parser = new MessageParser<GetAllSaveRaidScRsp>(() => new GetAllSaveRaidScRsp());

		// Token: 0x04001BE3 RID: 7139
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BE4 RID: 7140
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04001BE5 RID: 7141
		private uint retcode_;

		// Token: 0x04001BE6 RID: 7142
		public const int RaidDataListFieldNumber = 6;

		// Token: 0x04001BE7 RID: 7143
		private static readonly FieldCodec<RaidData> _repeated_raidDataList_codec = FieldCodec.ForMessage<RaidData>(50U, RaidData.Parser);

		// Token: 0x04001BE8 RID: 7144
		private readonly RepeatedField<RaidData> raidDataList_ = new RepeatedField<RaidData>();
	}
}
