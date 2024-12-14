using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200052B RID: 1323
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FightFestScoreUpdateNotify : IMessage<FightFestScoreUpdateNotify>, IMessage, IEquatable<FightFestScoreUpdateNotify>, IDeepCloneable<FightFestScoreUpdateNotify>, IBufferMessage
	{
		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x06003B34 RID: 15156 RVA: 0x000A2DB5 File Offset: 0x000A0FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FightFestScoreUpdateNotify> Parser
		{
			get
			{
				return FightFestScoreUpdateNotify._parser;
			}
		}

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x06003B35 RID: 15157 RVA: 0x000A2DBC File Offset: 0x000A0FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FightFestScoreUpdateNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06003B36 RID: 15158 RVA: 0x000A2DCE File Offset: 0x000A0FCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FightFestScoreUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x000A2DD5 File Offset: 0x000A0FD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFestScoreUpdateNotify()
		{
		}

		// Token: 0x06003B38 RID: 15160 RVA: 0x000A2DDD File Offset: 0x000A0FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFestScoreUpdateNotify(FightFestScoreUpdateNotify other) : this()
		{
			this.scoreId_ = other.scoreId_;
			this.gFKMCCDPNAH_ = other.gFKMCCDPNAH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003B39 RID: 15161 RVA: 0x000A2E0E File Offset: 0x000A100E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFestScoreUpdateNotify Clone()
		{
			return new FightFestScoreUpdateNotify(this);
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x06003B3A RID: 15162 RVA: 0x000A2E16 File Offset: 0x000A1016
		// (set) Token: 0x06003B3B RID: 15163 RVA: 0x000A2E1E File Offset: 0x000A101E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScoreId
		{
			get
			{
				return this.scoreId_;
			}
			set
			{
				this.scoreId_ = value;
			}
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x06003B3C RID: 15164 RVA: 0x000A2E27 File Offset: 0x000A1027
		// (set) Token: 0x06003B3D RID: 15165 RVA: 0x000A2E2F File Offset: 0x000A102F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GFKMCCDPNAH
		{
			get
			{
				return this.gFKMCCDPNAH_;
			}
			set
			{
				this.gFKMCCDPNAH_ = value;
			}
		}

		// Token: 0x06003B3E RID: 15166 RVA: 0x000A2E38 File Offset: 0x000A1038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FightFestScoreUpdateNotify);
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x000A2E46 File Offset: 0x000A1046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FightFestScoreUpdateNotify other)
		{
			return other != null && (other == this || (this.ScoreId == other.ScoreId && this.GFKMCCDPNAH == other.GFKMCCDPNAH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x000A2E84 File Offset: 0x000A1084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this.GFKMCCDPNAH != 0U)
			{
				num ^= this.GFKMCCDPNAH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x000A2EDC File Offset: 0x000A10DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003B42 RID: 15170 RVA: 0x000A2EE4 File Offset: 0x000A10E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x000A2EF0 File Offset: 0x000A10F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.ScoreId);
			}
			if (this.GFKMCCDPNAH != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.GFKMCCDPNAH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B44 RID: 15172 RVA: 0x000A2F4C File Offset: 0x000A114C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ScoreId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			if (this.GFKMCCDPNAH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GFKMCCDPNAH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x000A2FA4 File Offset: 0x000A11A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FightFestScoreUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			if (other.GFKMCCDPNAH != 0U)
			{
				this.GFKMCCDPNAH = other.GFKMCCDPNAH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x000A2FF4 File Offset: 0x000A11F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x000A3000 File Offset: 0x000A1200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GFKMCCDPNAH = input.ReadUInt32();
					}
				}
				else
				{
					this.ScoreId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040017D1 RID: 6097
		private static readonly MessageParser<FightFestScoreUpdateNotify> _parser = new MessageParser<FightFestScoreUpdateNotify>(() => new FightFestScoreUpdateNotify());

		// Token: 0x040017D2 RID: 6098
		private UnknownFieldSet _unknownFields;

		// Token: 0x040017D3 RID: 6099
		public const int ScoreIdFieldNumber = 9;

		// Token: 0x040017D4 RID: 6100
		private uint scoreId_;

		// Token: 0x040017D5 RID: 6101
		public const int GFKMCCDPNAHFieldNumber = 10;

		// Token: 0x040017D6 RID: 6102
		private uint gFKMCCDPNAH_;
	}
}
