using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E07 RID: 3591
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueArea : IMessage<RogueArea>, IMessage, IEquatable<RogueArea>, IDeepCloneable<RogueArea>, IBufferMessage
	{
		// Token: 0x17002D55 RID: 11605
		// (get) Token: 0x0600A090 RID: 41104 RVA: 0x001AED1F File Offset: 0x001ACF1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueArea> Parser
		{
			get
			{
				return RogueArea._parser;
			}
		}

		// Token: 0x17002D56 RID: 11606
		// (get) Token: 0x0600A091 RID: 41105 RVA: 0x001AED26 File Offset: 0x001ACF26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueAreaReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D57 RID: 11607
		// (get) Token: 0x0600A092 RID: 41106 RVA: 0x001AED38 File Offset: 0x001ACF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueArea.Descriptor;
			}
		}

		// Token: 0x0600A093 RID: 41107 RVA: 0x001AED3F File Offset: 0x001ACF3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArea()
		{
		}

		// Token: 0x0600A094 RID: 41108 RVA: 0x001AED48 File Offset: 0x001ACF48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArea(RogueArea other) : this()
		{
			this.areaId_ = other.areaId_;
			this.hasTakenReward_ = other.hasTakenReward_;
			this.mapId_ = other.mapId_;
			this.areaStatus_ = other.areaStatus_;
			this.rogueStatus_ = other.rogueStatus_;
			this.bGJKOLNCOPN_ = other.bGJKOLNCOPN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A095 RID: 41109 RVA: 0x001AEDB4 File Offset: 0x001ACFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArea Clone()
		{
			return new RogueArea(this);
		}

		// Token: 0x17002D58 RID: 11608
		// (get) Token: 0x0600A096 RID: 41110 RVA: 0x001AEDBC File Offset: 0x001ACFBC
		// (set) Token: 0x0600A097 RID: 41111 RVA: 0x001AEDC4 File Offset: 0x001ACFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x17002D59 RID: 11609
		// (get) Token: 0x0600A098 RID: 41112 RVA: 0x001AEDCD File Offset: 0x001ACFCD
		// (set) Token: 0x0600A099 RID: 41113 RVA: 0x001AEDD5 File Offset: 0x001ACFD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTakenReward
		{
			get
			{
				return this.hasTakenReward_;
			}
			set
			{
				this.hasTakenReward_ = value;
			}
		}

		// Token: 0x17002D5A RID: 11610
		// (get) Token: 0x0600A09A RID: 41114 RVA: 0x001AEDDE File Offset: 0x001ACFDE
		// (set) Token: 0x0600A09B RID: 41115 RVA: 0x001AEDE6 File Offset: 0x001ACFE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x17002D5B RID: 11611
		// (get) Token: 0x0600A09C RID: 41116 RVA: 0x001AEDEF File Offset: 0x001ACFEF
		// (set) Token: 0x0600A09D RID: 41117 RVA: 0x001AEDF7 File Offset: 0x001ACFF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAreaStatus AreaStatus
		{
			get
			{
				return this.areaStatus_;
			}
			set
			{
				this.areaStatus_ = value;
			}
		}

		// Token: 0x17002D5C RID: 11612
		// (get) Token: 0x0600A09E RID: 41118 RVA: 0x001AEE00 File Offset: 0x001AD000
		// (set) Token: 0x0600A09F RID: 41119 RVA: 0x001AEE08 File Offset: 0x001AD008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueStatus RogueStatus
		{
			get
			{
				return this.rogueStatus_;
			}
			set
			{
				this.rogueStatus_ = value;
			}
		}

		// Token: 0x17002D5D RID: 11613
		// (get) Token: 0x0600A0A0 RID: 41120 RVA: 0x001AEE11 File Offset: 0x001AD011
		// (set) Token: 0x0600A0A1 RID: 41121 RVA: 0x001AEE19 File Offset: 0x001AD019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BGJKOLNCOPN
		{
			get
			{
				return this.bGJKOLNCOPN_;
			}
			set
			{
				this.bGJKOLNCOPN_ = value;
			}
		}

		// Token: 0x0600A0A2 RID: 41122 RVA: 0x001AEE22 File Offset: 0x001AD022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueArea);
		}

		// Token: 0x0600A0A3 RID: 41123 RVA: 0x001AEE30 File Offset: 0x001AD030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueArea other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && this.HasTakenReward == other.HasTakenReward && this.MapId == other.MapId && this.AreaStatus == other.AreaStatus && this.RogueStatus == other.RogueStatus && this.BGJKOLNCOPN == other.BGJKOLNCOPN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A0A4 RID: 41124 RVA: 0x001AEEBC File Offset: 0x001AD0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this.HasTakenReward)
			{
				num ^= this.HasTakenReward.GetHashCode();
			}
			if (this.MapId != 0U)
			{
				num ^= this.MapId.GetHashCode();
			}
			if (this.AreaStatus != RogueAreaStatus.Lock)
			{
				num ^= this.AreaStatus.GetHashCode();
			}
			if (this.RogueStatus != RogueStatus.None)
			{
				num ^= this.RogueStatus.GetHashCode();
			}
			if (this.BGJKOLNCOPN != 0U)
			{
				num ^= this.BGJKOLNCOPN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A0A5 RID: 41125 RVA: 0x001AEF85 File Offset: 0x001AD185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A0A6 RID: 41126 RVA: 0x001AEF8D File Offset: 0x001AD18D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A0A7 RID: 41127 RVA: 0x001AEF98 File Offset: 0x001AD198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaStatus != RogueAreaStatus.Lock)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.AreaStatus);
			}
			if (this.MapId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.MapId);
			}
			if (this.BGJKOLNCOPN != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.BGJKOLNCOPN);
			}
			if (this.RogueStatus != RogueStatus.None)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.RogueStatus);
			}
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.AreaId);
			}
			if (this.HasTakenReward)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.HasTakenReward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A0A8 RID: 41128 RVA: 0x001AF064 File Offset: 0x001AD264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			if (this.HasTakenReward)
			{
				num += 2;
			}
			if (this.MapId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MapId);
			}
			if (this.AreaStatus != RogueAreaStatus.Lock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AreaStatus);
			}
			if (this.RogueStatus != RogueStatus.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RogueStatus);
			}
			if (this.BGJKOLNCOPN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BGJKOLNCOPN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A0A9 RID: 41129 RVA: 0x001AF110 File Offset: 0x001AD310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueArea other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			if (other.HasTakenReward)
			{
				this.HasTakenReward = other.HasTakenReward;
			}
			if (other.MapId != 0U)
			{
				this.MapId = other.MapId;
			}
			if (other.AreaStatus != RogueAreaStatus.Lock)
			{
				this.AreaStatus = other.AreaStatus;
			}
			if (other.RogueStatus != RogueStatus.None)
			{
				this.RogueStatus = other.RogueStatus;
			}
			if (other.BGJKOLNCOPN != 0U)
			{
				this.BGJKOLNCOPN = other.BGJKOLNCOPN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A0AA RID: 41130 RVA: 0x001AF1B0 File Offset: 0x001AD3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A0AB RID: 41131 RVA: 0x001AF1BC File Offset: 0x001AD3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 80U)
				{
					if (num == 40U)
					{
						this.AreaStatus = (RogueAreaStatus)input.ReadEnum();
						continue;
					}
					if (num == 56U)
					{
						this.MapId = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.BGJKOLNCOPN = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.RogueStatus = (RogueStatus)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.AreaId = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.HasTakenReward = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040041C3 RID: 16835
		private static readonly MessageParser<RogueArea> _parser = new MessageParser<RogueArea>(() => new RogueArea());

		// Token: 0x040041C4 RID: 16836
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041C5 RID: 16837
		public const int AreaIdFieldNumber = 14;

		// Token: 0x040041C6 RID: 16838
		private uint areaId_;

		// Token: 0x040041C7 RID: 16839
		public const int HasTakenRewardFieldNumber = 15;

		// Token: 0x040041C8 RID: 16840
		private bool hasTakenReward_;

		// Token: 0x040041C9 RID: 16841
		public const int MapIdFieldNumber = 7;

		// Token: 0x040041CA RID: 16842
		private uint mapId_;

		// Token: 0x040041CB RID: 16843
		public const int AreaStatusFieldNumber = 5;

		// Token: 0x040041CC RID: 16844
		private RogueAreaStatus areaStatus_;

		// Token: 0x040041CD RID: 16845
		public const int RogueStatusFieldNumber = 13;

		// Token: 0x040041CE RID: 16846
		private RogueStatus rogueStatus_;

		// Token: 0x040041CF RID: 16847
		public const int BGJKOLNCOPNFieldNumber = 10;

		// Token: 0x040041D0 RID: 16848
		private uint bGJKOLNCOPN_;
	}
}
