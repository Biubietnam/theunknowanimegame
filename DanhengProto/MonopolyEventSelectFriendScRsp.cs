using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B2B RID: 2859
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyEventSelectFriendScRsp : IMessage<MonopolyEventSelectFriendScRsp>, IMessage, IEquatable<MonopolyEventSelectFriendScRsp>, IDeepCloneable<MonopolyEventSelectFriendScRsp>, IBufferMessage
	{
		// Token: 0x1700237F RID: 9087
		// (get) Token: 0x06007E88 RID: 32392 RVA: 0x0014E7EF File Offset: 0x0014C9EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyEventSelectFriendScRsp> Parser
		{
			get
			{
				return MonopolyEventSelectFriendScRsp._parser;
			}
		}

		// Token: 0x17002380 RID: 9088
		// (get) Token: 0x06007E89 RID: 32393 RVA: 0x0014E7F6 File Offset: 0x0014C9F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyEventSelectFriendScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002381 RID: 9089
		// (get) Token: 0x06007E8A RID: 32394 RVA: 0x0014E808 File Offset: 0x0014CA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyEventSelectFriendScRsp.Descriptor;
			}
		}

		// Token: 0x06007E8B RID: 32395 RVA: 0x0014E80F File Offset: 0x0014CA0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyEventSelectFriendScRsp()
		{
		}

		// Token: 0x06007E8C RID: 32396 RVA: 0x0014E818 File Offset: 0x0014CA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyEventSelectFriendScRsp(MonopolyEventSelectFriendScRsp other) : this()
		{
			this.iDJGOIDALMN_ = other.iDJGOIDALMN_;
			this.getItemList_ = other.getItemList_;
			this.gGMHDPCMGFP_ = ((other.gGMHDPCMGFP_ != null) ? other.gGMHDPCMGFP_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E8D RID: 32397 RVA: 0x0014E87C File Offset: 0x0014CA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyEventSelectFriendScRsp Clone()
		{
			return new MonopolyEventSelectFriendScRsp(this);
		}

		// Token: 0x17002382 RID: 9090
		// (get) Token: 0x06007E8E RID: 32398 RVA: 0x0014E884 File Offset: 0x0014CA84
		// (set) Token: 0x06007E8F RID: 32399 RVA: 0x0014E88C File Offset: 0x0014CA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IDJGOIDALMN
		{
			get
			{
				return this.iDJGOIDALMN_;
			}
			set
			{
				this.iDJGOIDALMN_ = value;
			}
		}

		// Token: 0x17002383 RID: 9091
		// (get) Token: 0x06007E90 RID: 32400 RVA: 0x0014E895 File Offset: 0x0014CA95
		// (set) Token: 0x06007E91 RID: 32401 RVA: 0x0014E89D File Offset: 0x0014CA9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GetItemList
		{
			get
			{
				return this.getItemList_;
			}
			set
			{
				this.getItemList_ = value;
			}
		}

		// Token: 0x17002384 RID: 9092
		// (get) Token: 0x06007E92 RID: 32402 RVA: 0x0014E8A6 File Offset: 0x0014CAA6
		// (set) Token: 0x06007E93 RID: 32403 RVA: 0x0014E8AE File Offset: 0x0014CAAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DHAIJMPAJDL GGMHDPCMGFP
		{
			get
			{
				return this.gGMHDPCMGFP_;
			}
			set
			{
				this.gGMHDPCMGFP_ = value;
			}
		}

		// Token: 0x17002385 RID: 9093
		// (get) Token: 0x06007E94 RID: 32404 RVA: 0x0014E8B7 File Offset: 0x0014CAB7
		// (set) Token: 0x06007E95 RID: 32405 RVA: 0x0014E8BF File Offset: 0x0014CABF
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

		// Token: 0x06007E96 RID: 32406 RVA: 0x0014E8C8 File Offset: 0x0014CAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyEventSelectFriendScRsp);
		}

		// Token: 0x06007E97 RID: 32407 RVA: 0x0014E8D8 File Offset: 0x0014CAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyEventSelectFriendScRsp other)
		{
			return other != null && (other == this || (this.IDJGOIDALMN == other.IDJGOIDALMN && this.GetItemList == other.GetItemList && object.Equals(this.GGMHDPCMGFP, other.GGMHDPCMGFP) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E98 RID: 32408 RVA: 0x0014E948 File Offset: 0x0014CB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IDJGOIDALMN != 0U)
			{
				num ^= this.IDJGOIDALMN.GetHashCode();
			}
			if (this.GetItemList != 0U)
			{
				num ^= this.GetItemList.GetHashCode();
			}
			if (this.gGMHDPCMGFP_ != null)
			{
				num ^= this.GGMHDPCMGFP.GetHashCode();
			}
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

		// Token: 0x06007E99 RID: 32409 RVA: 0x0014E9CF File Offset: 0x0014CBCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007E9A RID: 32410 RVA: 0x0014E9D7 File Offset: 0x0014CBD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E9B RID: 32411 RVA: 0x0014E9E0 File Offset: 0x0014CBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IDJGOIDALMN != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.IDJGOIDALMN);
			}
			if (this.gGMHDPCMGFP_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.GGMHDPCMGFP);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.GetItemList != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.GetItemList);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E9C RID: 32412 RVA: 0x0014EA70 File Offset: 0x0014CC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IDJGOIDALMN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IDJGOIDALMN);
			}
			if (this.GetItemList != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GetItemList);
			}
			if (this.gGMHDPCMGFP_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GGMHDPCMGFP);
			}
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

		// Token: 0x06007E9D RID: 32413 RVA: 0x0014EAF8 File Offset: 0x0014CCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyEventSelectFriendScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IDJGOIDALMN != 0U)
			{
				this.IDJGOIDALMN = other.IDJGOIDALMN;
			}
			if (other.GetItemList != 0U)
			{
				this.GetItemList = other.GetItemList;
			}
			if (other.gGMHDPCMGFP_ != null)
			{
				if (this.gGMHDPCMGFP_ == null)
				{
					this.GGMHDPCMGFP = new DHAIJMPAJDL();
				}
				this.GGMHDPCMGFP.MergeFrom(other.GGMHDPCMGFP);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007E9E RID: 32414 RVA: 0x0014EB88 File Offset: 0x0014CD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E9F RID: 32415 RVA: 0x0014EB94 File Offset: 0x0014CD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 58U)
				{
					if (num == 8U)
					{
						this.IDJGOIDALMN = input.ReadUInt32();
						continue;
					}
					if (num == 58U)
					{
						if (this.gGMHDPCMGFP_ == null)
						{
							this.GGMHDPCMGFP = new DHAIJMPAJDL();
						}
						input.ReadMessage(this.GGMHDPCMGFP);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.GetItemList = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003083 RID: 12419
		private static readonly MessageParser<MonopolyEventSelectFriendScRsp> _parser = new MessageParser<MonopolyEventSelectFriendScRsp>(() => new MonopolyEventSelectFriendScRsp());

		// Token: 0x04003084 RID: 12420
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003085 RID: 12421
		public const int IDJGOIDALMNFieldNumber = 1;

		// Token: 0x04003086 RID: 12422
		private uint iDJGOIDALMN_;

		// Token: 0x04003087 RID: 12423
		public const int GetItemListFieldNumber = 11;

		// Token: 0x04003088 RID: 12424
		private uint getItemList_;

		// Token: 0x04003089 RID: 12425
		public const int GGMHDPCMGFPFieldNumber = 7;

		// Token: 0x0400308A RID: 12426
		private DHAIJMPAJDL gGMHDPCMGFP_;

		// Token: 0x0400308B RID: 12427
		public const int RetcodeFieldNumber = 8;

		// Token: 0x0400308C RID: 12428
		private uint retcode_;
	}
}
