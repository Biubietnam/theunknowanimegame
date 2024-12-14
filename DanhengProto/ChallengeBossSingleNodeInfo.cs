using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200019F RID: 415
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeBossSingleNodeInfo : IMessage<ChallengeBossSingleNodeInfo>, IMessage, IEquatable<ChallengeBossSingleNodeInfo>, IDeepCloneable<ChallengeBossSingleNodeInfo>, IBufferMessage
	{
		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x00035FA1 File Offset: 0x000341A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeBossSingleNodeInfo> Parser
		{
			get
			{
				return ChallengeBossSingleNodeInfo._parser;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x00035FA8 File Offset: 0x000341A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeBossSingleNodeInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x00035FBA File Offset: 0x000341BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeBossSingleNodeInfo.Descriptor;
			}
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x00035FC1 File Offset: 0x000341C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossSingleNodeInfo()
		{
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x00035FCC File Offset: 0x000341CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossSingleNodeInfo(ChallengeBossSingleNodeInfo other) : this()
		{
			this.hGIDJHFNCMA_ = other.hGIDJHFNCMA_;
			this.isWin_ = other.isWin_;
			this.maxScore_ = other.maxScore_;
			this.buffId_ = other.buffId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00036020 File Offset: 0x00034220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossSingleNodeInfo Clone()
		{
			return new ChallengeBossSingleNodeInfo(this);
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x00036028 File Offset: 0x00034228
		// (set) Token: 0x060012AB RID: 4779 RVA: 0x00036030 File Offset: 0x00034230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HGIDJHFNCMA
		{
			get
			{
				return this.hGIDJHFNCMA_;
			}
			set
			{
				this.hGIDJHFNCMA_ = value;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x00036039 File Offset: 0x00034239
		// (set) Token: 0x060012AD RID: 4781 RVA: 0x00036041 File Offset: 0x00034241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsWin
		{
			get
			{
				return this.isWin_;
			}
			set
			{
				this.isWin_ = value;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x0003604A File Offset: 0x0003424A
		// (set) Token: 0x060012AF RID: 4783 RVA: 0x00036052 File Offset: 0x00034252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxScore
		{
			get
			{
				return this.maxScore_;
			}
			set
			{
				this.maxScore_ = value;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x0003605B File Offset: 0x0003425B
		// (set) Token: 0x060012B1 RID: 4785 RVA: 0x00036063 File Offset: 0x00034263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BuffId
		{
			get
			{
				return this.buffId_;
			}
			set
			{
				this.buffId_ = value;
			}
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x0003606C File Offset: 0x0003426C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeBossSingleNodeInfo);
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x0003607C File Offset: 0x0003427C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeBossSingleNodeInfo other)
		{
			return other != null && (other == this || (this.HGIDJHFNCMA == other.HGIDJHFNCMA && this.IsWin == other.IsWin && this.MaxScore == other.MaxScore && this.BuffId == other.BuffId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x000360E8 File Offset: 0x000342E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HGIDJHFNCMA)
			{
				num ^= this.HGIDJHFNCMA.GetHashCode();
			}
			if (this.IsWin)
			{
				num ^= this.IsWin.GetHashCode();
			}
			if (this.MaxScore != 0U)
			{
				num ^= this.MaxScore.GetHashCode();
			}
			if (this.BuffId != 0U)
			{
				num ^= this.BuffId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00036172 File Offset: 0x00034372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x0003617A File Offset: 0x0003437A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x00036184 File Offset: 0x00034384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsWin)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsWin);
			}
			if (this.HGIDJHFNCMA)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.HGIDJHFNCMA);
			}
			if (this.BuffId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.BuffId);
			}
			if (this.MaxScore != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.MaxScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00036218 File Offset: 0x00034418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HGIDJHFNCMA)
			{
				num += 2;
			}
			if (this.IsWin)
			{
				num += 2;
			}
			if (this.MaxScore != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxScore);
			}
			if (this.BuffId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BuffId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00036288 File Offset: 0x00034488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeBossSingleNodeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HGIDJHFNCMA)
			{
				this.HGIDJHFNCMA = other.HGIDJHFNCMA;
			}
			if (other.IsWin)
			{
				this.IsWin = other.IsWin;
			}
			if (other.MaxScore != 0U)
			{
				this.MaxScore = other.MaxScore;
			}
			if (other.BuffId != 0U)
			{
				this.BuffId = other.BuffId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x00036300 File Offset: 0x00034500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x0003630C File Offset: 0x0003450C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 32U)
					{
						this.IsWin = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.HGIDJHFNCMA = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.BuffId = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.MaxScore = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040007E5 RID: 2021
		private static readonly MessageParser<ChallengeBossSingleNodeInfo> _parser = new MessageParser<ChallengeBossSingleNodeInfo>(() => new ChallengeBossSingleNodeInfo());

		// Token: 0x040007E6 RID: 2022
		private UnknownFieldSet _unknownFields;

		// Token: 0x040007E7 RID: 2023
		public const int HGIDJHFNCMAFieldNumber = 5;

		// Token: 0x040007E8 RID: 2024
		private bool hGIDJHFNCMA_;

		// Token: 0x040007E9 RID: 2025
		public const int IsWinFieldNumber = 4;

		// Token: 0x040007EA RID: 2026
		private bool isWin_;

		// Token: 0x040007EB RID: 2027
		public const int MaxScoreFieldNumber = 12;

		// Token: 0x040007EC RID: 2028
		private uint maxScore_;

		// Token: 0x040007ED RID: 2029
		public const int BuffIdFieldNumber = 9;

		// Token: 0x040007EE RID: 2030
		private uint buffId_;
	}
}
