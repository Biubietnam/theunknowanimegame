using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200061D RID: 1565
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAssistHistoryScRsp : IMessage<GetAssistHistoryScRsp>, IMessage, IEquatable<GetAssistHistoryScRsp>, IDeepCloneable<GetAssistHistoryScRsp>, IBufferMessage
	{
		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x06004623 RID: 17955 RVA: 0x000BFF37 File Offset: 0x000BE137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAssistHistoryScRsp> Parser
		{
			get
			{
				return GetAssistHistoryScRsp._parser;
			}
		}

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x06004624 RID: 17956 RVA: 0x000BFF3E File Offset: 0x000BE13E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAssistHistoryScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x06004625 RID: 17957 RVA: 0x000BFF50 File Offset: 0x000BE150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAssistHistoryScRsp.Descriptor;
			}
		}

		// Token: 0x06004626 RID: 17958 RVA: 0x000BFF57 File Offset: 0x000BE157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAssistHistoryScRsp()
		{
		}

		// Token: 0x06004627 RID: 17959 RVA: 0x000BFF6C File Offset: 0x000BE16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAssistHistoryScRsp(GetAssistHistoryScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.iEMFIJGNMGF_ = other.iEMFIJGNMGF_;
			this.lLFKHHCBDAF_ = other.lLFKHHCBDAF_;
			this.todayUseUidList_ = other.todayUseUidList_.Clone();
			this.bDPEABBJEPO_ = other.bDPEABBJEPO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x000BFFD1 File Offset: 0x000BE1D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAssistHistoryScRsp Clone()
		{
			return new GetAssistHistoryScRsp(this);
		}

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x06004629 RID: 17961 RVA: 0x000BFFD9 File Offset: 0x000BE1D9
		// (set) Token: 0x0600462A RID: 17962 RVA: 0x000BFFE1 File Offset: 0x000BE1E1
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

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x0600462B RID: 17963 RVA: 0x000BFFEA File Offset: 0x000BE1EA
		// (set) Token: 0x0600462C RID: 17964 RVA: 0x000BFFF2 File Offset: 0x000BE1F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IEMFIJGNMGF
		{
			get
			{
				return this.iEMFIJGNMGF_;
			}
			set
			{
				this.iEMFIJGNMGF_ = value;
			}
		}

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x0600462D RID: 17965 RVA: 0x000BFFFB File Offset: 0x000BE1FB
		// (set) Token: 0x0600462E RID: 17966 RVA: 0x000C0003 File Offset: 0x000BE203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LLFKHHCBDAF
		{
			get
			{
				return this.lLFKHHCBDAF_;
			}
			set
			{
				this.lLFKHHCBDAF_ = value;
			}
		}

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x0600462F RID: 17967 RVA: 0x000C000C File Offset: 0x000BE20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TodayUseUidList
		{
			get
			{
				return this.todayUseUidList_;
			}
		}

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x06004630 RID: 17968 RVA: 0x000C0014 File Offset: 0x000BE214
		// (set) Token: 0x06004631 RID: 17969 RVA: 0x000C001C File Offset: 0x000BE21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BDPEABBJEPO
		{
			get
			{
				return this.bDPEABBJEPO_;
			}
			set
			{
				this.bDPEABBJEPO_ = value;
			}
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x000C0025 File Offset: 0x000BE225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAssistHistoryScRsp);
		}

		// Token: 0x06004633 RID: 17971 RVA: 0x000C0034 File Offset: 0x000BE234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAssistHistoryScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.IEMFIJGNMGF == other.IEMFIJGNMGF && this.LLFKHHCBDAF == other.LLFKHHCBDAF && this.todayUseUidList_.Equals(other.todayUseUidList_) && this.BDPEABBJEPO == other.BDPEABBJEPO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004634 RID: 17972 RVA: 0x000C00B4 File Offset: 0x000BE2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.IEMFIJGNMGF != 0U)
			{
				num ^= this.IEMFIJGNMGF.GetHashCode();
			}
			if (this.LLFKHHCBDAF != 0U)
			{
				num ^= this.LLFKHHCBDAF.GetHashCode();
			}
			num ^= this.todayUseUidList_.GetHashCode();
			if (this.BDPEABBJEPO != 0U)
			{
				num ^= this.BDPEABBJEPO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004635 RID: 17973 RVA: 0x000C014C File Offset: 0x000BE34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004636 RID: 17974 RVA: 0x000C0154 File Offset: 0x000BE354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x000C0160 File Offset: 0x000BE360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LLFKHHCBDAF != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.LLFKHHCBDAF);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.IEMFIJGNMGF != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.IEMFIJGNMGF);
			}
			if (this.BDPEABBJEPO != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.BDPEABBJEPO);
			}
			this.todayUseUidList_.WriteTo(ref output, GetAssistHistoryScRsp._repeated_todayUseUidList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004638 RID: 17976 RVA: 0x000C0204 File Offset: 0x000BE404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.IEMFIJGNMGF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IEMFIJGNMGF);
			}
			if (this.LLFKHHCBDAF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LLFKHHCBDAF);
			}
			num += this.todayUseUidList_.CalculateSize(GetAssistHistoryScRsp._repeated_todayUseUidList_codec);
			if (this.BDPEABBJEPO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BDPEABBJEPO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004639 RID: 17977 RVA: 0x000C02A0 File Offset: 0x000BE4A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAssistHistoryScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.IEMFIJGNMGF != 0U)
			{
				this.IEMFIJGNMGF = other.IEMFIJGNMGF;
			}
			if (other.LLFKHHCBDAF != 0U)
			{
				this.LLFKHHCBDAF = other.LLFKHHCBDAF;
			}
			this.todayUseUidList_.Add(other.todayUseUidList_);
			if (other.BDPEABBJEPO != 0U)
			{
				this.BDPEABBJEPO = other.BDPEABBJEPO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600463A RID: 17978 RVA: 0x000C0329 File Offset: 0x000BE529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600463B RID: 17979 RVA: 0x000C0334 File Offset: 0x000BE534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 24U)
					{
						this.LLFKHHCBDAF = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.IEMFIJGNMGF = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.BDPEABBJEPO = input.ReadUInt32();
						continue;
					}
					if (num == 112U || num == 114U)
					{
						this.todayUseUidList_.AddEntriesFrom(ref input, GetAssistHistoryScRsp._repeated_todayUseUidList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001C02 RID: 7170
		private static readonly MessageParser<GetAssistHistoryScRsp> _parser = new MessageParser<GetAssistHistoryScRsp>(() => new GetAssistHistoryScRsp());

		// Token: 0x04001C03 RID: 7171
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C04 RID: 7172
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04001C05 RID: 7173
		private uint retcode_;

		// Token: 0x04001C06 RID: 7174
		public const int IEMFIJGNMGFFieldNumber = 7;

		// Token: 0x04001C07 RID: 7175
		private uint iEMFIJGNMGF_;

		// Token: 0x04001C08 RID: 7176
		public const int LLFKHHCBDAFFieldNumber = 3;

		// Token: 0x04001C09 RID: 7177
		private uint lLFKHHCBDAF_;

		// Token: 0x04001C0A RID: 7178
		public const int TodayUseUidListFieldNumber = 14;

		// Token: 0x04001C0B RID: 7179
		private static readonly FieldCodec<uint> _repeated_todayUseUidList_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x04001C0C RID: 7180
		private readonly RepeatedField<uint> todayUseUidList_ = new RepeatedField<uint>();

		// Token: 0x04001C0D RID: 7181
		public const int BDPEABBJEPOFieldNumber = 10;

		// Token: 0x04001C0E RID: 7182
		private uint bDPEABBJEPO_;
	}
}
