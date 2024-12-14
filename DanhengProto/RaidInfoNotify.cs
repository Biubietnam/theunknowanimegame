using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D6D RID: 3437
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RaidInfoNotify : IMessage<RaidInfoNotify>, IMessage, IEquatable<RaidInfoNotify>, IDeepCloneable<RaidInfoNotify>, IBufferMessage
	{
		// Token: 0x17002B54 RID: 11092
		// (get) Token: 0x06009992 RID: 39314 RVA: 0x00198CA3 File Offset: 0x00196EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RaidInfoNotify> Parser
		{
			get
			{
				return RaidInfoNotify._parser;
			}
		}

		// Token: 0x17002B55 RID: 11093
		// (get) Token: 0x06009993 RID: 39315 RVA: 0x00198CAA File Offset: 0x00196EAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RaidInfoNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B56 RID: 11094
		// (get) Token: 0x06009994 RID: 39316 RVA: 0x00198CBC File Offset: 0x00196EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RaidInfoNotify.Descriptor;
			}
		}

		// Token: 0x06009995 RID: 39317 RVA: 0x00198CC3 File Offset: 0x00196EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidInfoNotify()
		{
		}

		// Token: 0x06009996 RID: 39318 RVA: 0x00198CD8 File Offset: 0x00196ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidInfoNotify(RaidInfoNotify other) : this()
		{
			this.raidFinishTime_ = other.raidFinishTime_;
			this.raidId_ = other.raidId_;
			this.status_ = other.status_;
			this.worldLevel_ = other.worldLevel_;
			this.itemList_ = ((other.itemList_ != null) ? other.itemList_.Clone() : null);
			this.raidTargetInfo_ = other.raidTargetInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009997 RID: 39319 RVA: 0x00198D59 File Offset: 0x00196F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidInfoNotify Clone()
		{
			return new RaidInfoNotify(this);
		}

		// Token: 0x17002B57 RID: 11095
		// (get) Token: 0x06009998 RID: 39320 RVA: 0x00198D61 File Offset: 0x00196F61
		// (set) Token: 0x06009999 RID: 39321 RVA: 0x00198D69 File Offset: 0x00196F69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong RaidFinishTime
		{
			get
			{
				return this.raidFinishTime_;
			}
			set
			{
				this.raidFinishTime_ = value;
			}
		}

		// Token: 0x17002B58 RID: 11096
		// (get) Token: 0x0600999A RID: 39322 RVA: 0x00198D72 File Offset: 0x00196F72
		// (set) Token: 0x0600999B RID: 39323 RVA: 0x00198D7A File Offset: 0x00196F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RaidId
		{
			get
			{
				return this.raidId_;
			}
			set
			{
				this.raidId_ = value;
			}
		}

		// Token: 0x17002B59 RID: 11097
		// (get) Token: 0x0600999C RID: 39324 RVA: 0x00198D83 File Offset: 0x00196F83
		// (set) Token: 0x0600999D RID: 39325 RVA: 0x00198D8B File Offset: 0x00196F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x17002B5A RID: 11098
		// (get) Token: 0x0600999E RID: 39326 RVA: 0x00198D94 File Offset: 0x00196F94
		// (set) Token: 0x0600999F RID: 39327 RVA: 0x00198D9C File Offset: 0x00196F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint WorldLevel
		{
			get
			{
				return this.worldLevel_;
			}
			set
			{
				this.worldLevel_ = value;
			}
		}

		// Token: 0x17002B5B RID: 11099
		// (get) Token: 0x060099A0 RID: 39328 RVA: 0x00198DA5 File Offset: 0x00196FA5
		// (set) Token: 0x060099A1 RID: 39329 RVA: 0x00198DAD File Offset: 0x00196FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList ItemList
		{
			get
			{
				return this.itemList_;
			}
			set
			{
				this.itemList_ = value;
			}
		}

		// Token: 0x17002B5C RID: 11100
		// (get) Token: 0x060099A2 RID: 39330 RVA: 0x00198DB6 File Offset: 0x00196FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RaidTargetInfo> RaidTargetInfo
		{
			get
			{
				return this.raidTargetInfo_;
			}
		}

		// Token: 0x060099A3 RID: 39331 RVA: 0x00198DBE File Offset: 0x00196FBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RaidInfoNotify);
		}

		// Token: 0x060099A4 RID: 39332 RVA: 0x00198DCC File Offset: 0x00196FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RaidInfoNotify other)
		{
			return other != null && (other == this || (this.RaidFinishTime == other.RaidFinishTime && this.RaidId == other.RaidId && this.Status == other.Status && this.WorldLevel == other.WorldLevel && object.Equals(this.ItemList, other.ItemList) && this.raidTargetInfo_.Equals(other.raidTargetInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060099A5 RID: 39333 RVA: 0x00198E60 File Offset: 0x00197060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RaidFinishTime != 0UL)
			{
				num ^= this.RaidFinishTime.GetHashCode();
			}
			if (this.RaidId != 0U)
			{
				num ^= this.RaidId.GetHashCode();
			}
			if (this.Status != RaidStatus.None)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this.itemList_ != null)
			{
				num ^= this.ItemList.GetHashCode();
			}
			num ^= this.raidTargetInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060099A6 RID: 39334 RVA: 0x00198F14 File Offset: 0x00197114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060099A7 RID: 39335 RVA: 0x00198F1C File Offset: 0x0019711C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060099A8 RID: 39336 RVA: 0x00198F28 File Offset: 0x00197128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.raidTargetInfo_.WriteTo(ref output, RaidInfoNotify._repeated_raidTargetInfo_codec);
			if (this.Status != RaidStatus.None)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Status);
			}
			if (this.RaidId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.RaidId);
			}
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this.itemList_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.ItemList);
			}
			if (this.RaidFinishTime != 0UL)
			{
				output.WriteRawTag(120);
				output.WriteUInt64(this.RaidFinishTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060099A9 RID: 39337 RVA: 0x00198FE8 File Offset: 0x001971E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RaidFinishTime != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.RaidFinishTime);
			}
			if (this.RaidId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RaidId);
			}
			if (this.Status != RaidStatus.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this.itemList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ItemList);
			}
			num += this.raidTargetInfo_.CalculateSize(RaidInfoNotify._repeated_raidTargetInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060099AA RID: 39338 RVA: 0x0019909C File Offset: 0x0019729C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RaidInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RaidFinishTime != 0UL)
			{
				this.RaidFinishTime = other.RaidFinishTime;
			}
			if (other.RaidId != 0U)
			{
				this.RaidId = other.RaidId;
			}
			if (other.Status != RaidStatus.None)
			{
				this.Status = other.Status;
			}
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			if (other.itemList_ != null)
			{
				if (this.itemList_ == null)
				{
					this.ItemList = new ItemList();
				}
				this.ItemList.MergeFrom(other.ItemList);
			}
			this.raidTargetInfo_.Add(other.raidTargetInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060099AB RID: 39339 RVA: 0x00199151 File Offset: 0x00197351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060099AC RID: 39340 RVA: 0x0019915C File Offset: 0x0019735C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 18U)
					{
						this.raidTargetInfo_.AddEntriesFrom(ref input, RaidInfoNotify._repeated_raidTargetInfo_codec);
						continue;
					}
					if (num == 24U)
					{
						this.Status = (RaidStatus)input.ReadEnum();
						continue;
					}
					if (num == 56U)
					{
						this.RaidId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.WorldLevel = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						if (this.itemList_ == null)
						{
							this.ItemList = new ItemList();
						}
						input.ReadMessage(this.ItemList);
						continue;
					}
					if (num == 120U)
					{
						this.RaidFinishTime = input.ReadUInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003B9D RID: 15261
		private static readonly MessageParser<RaidInfoNotify> _parser = new MessageParser<RaidInfoNotify>(() => new RaidInfoNotify());

		// Token: 0x04003B9E RID: 15262
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B9F RID: 15263
		public const int RaidFinishTimeFieldNumber = 15;

		// Token: 0x04003BA0 RID: 15264
		private ulong raidFinishTime_;

		// Token: 0x04003BA1 RID: 15265
		public const int RaidIdFieldNumber = 7;

		// Token: 0x04003BA2 RID: 15266
		private uint raidId_;

		// Token: 0x04003BA3 RID: 15267
		public const int StatusFieldNumber = 3;

		// Token: 0x04003BA4 RID: 15268
		private RaidStatus status_;

		// Token: 0x04003BA5 RID: 15269
		public const int WorldLevelFieldNumber = 10;

		// Token: 0x04003BA6 RID: 15270
		private uint worldLevel_;

		// Token: 0x04003BA7 RID: 15271
		public const int ItemListFieldNumber = 14;

		// Token: 0x04003BA8 RID: 15272
		private ItemList itemList_;

		// Token: 0x04003BA9 RID: 15273
		public const int RaidTargetInfoFieldNumber = 2;

		// Token: 0x04003BAA RID: 15274
		private static readonly FieldCodec<RaidTargetInfo> _repeated_raidTargetInfo_codec = FieldCodec.ForMessage<RaidTargetInfo>(18U, EggLink.DanhengServer.Proto.RaidTargetInfo.Parser);

		// Token: 0x04003BAB RID: 15275
		private readonly RepeatedField<RaidTargetInfo> raidTargetInfo_ = new RepeatedField<RaidTargetInfo>();
	}
}
