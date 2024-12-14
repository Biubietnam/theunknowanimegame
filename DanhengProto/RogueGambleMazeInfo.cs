using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E8F RID: 3727
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueGambleMazeInfo : IMessage<RogueGambleMazeInfo>, IMessage, IEquatable<RogueGambleMazeInfo>, IDeepCloneable<RogueGambleMazeInfo>, IBufferMessage
	{
		// Token: 0x17002F06 RID: 12038
		// (get) Token: 0x0600A675 RID: 42613 RVA: 0x001C02F3 File Offset: 0x001BE4F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueGambleMazeInfo> Parser
		{
			get
			{
				return RogueGambleMazeInfo._parser;
			}
		}

		// Token: 0x17002F07 RID: 12039
		// (get) Token: 0x0600A676 RID: 42614 RVA: 0x001C02FA File Offset: 0x001BE4FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueGambleMazeInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F08 RID: 12040
		// (get) Token: 0x0600A677 RID: 42615 RVA: 0x001C030C File Offset: 0x001BE50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueGambleMazeInfo.Descriptor;
			}
		}

		// Token: 0x0600A678 RID: 42616 RVA: 0x001C0313 File Offset: 0x001BE513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGambleMazeInfo()
		{
		}

		// Token: 0x0600A679 RID: 42617 RVA: 0x001C031C File Offset: 0x001BE51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGambleMazeInfo(RogueGambleMazeInfo other) : this()
		{
			this.mazeId_ = other.mazeId_;
			this.mazeEnable_ = other.mazeEnable_;
			this.bKNGCBIBPFK_ = ((other.bKNGCBIBPFK_ != null) ? other.bKNGCBIBPFK_.Clone() : null);
			this.aHLAKKGPHGD_ = ((other.aHLAKKGPHGD_ != null) ? other.aHLAKKGPHGD_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A67A RID: 42618 RVA: 0x001C0390 File Offset: 0x001BE590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGambleMazeInfo Clone()
		{
			return new RogueGambleMazeInfo(this);
		}

		// Token: 0x17002F09 RID: 12041
		// (get) Token: 0x0600A67B RID: 42619 RVA: 0x001C0398 File Offset: 0x001BE598
		// (set) Token: 0x0600A67C RID: 42620 RVA: 0x001C03A0 File Offset: 0x001BE5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MazeId
		{
			get
			{
				return this.mazeId_;
			}
			set
			{
				this.mazeId_ = value;
			}
		}

		// Token: 0x17002F0A RID: 12042
		// (get) Token: 0x0600A67D RID: 42621 RVA: 0x001C03A9 File Offset: 0x001BE5A9
		// (set) Token: 0x0600A67E RID: 42622 RVA: 0x001C03B1 File Offset: 0x001BE5B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MazeEnable
		{
			get
			{
				return this.mazeEnable_;
			}
			set
			{
				this.mazeEnable_ = value;
			}
		}

		// Token: 0x17002F0B RID: 12043
		// (get) Token: 0x0600A67F RID: 42623 RVA: 0x001C03BA File Offset: 0x001BE5BA
		// (set) Token: 0x0600A680 RID: 42624 RVA: 0x001C03C2 File Offset: 0x001BE5C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ENHHGAMEKMB BKNGCBIBPFK
		{
			get
			{
				return this.bKNGCBIBPFK_;
			}
			set
			{
				this.bKNGCBIBPFK_ = value;
			}
		}

		// Token: 0x17002F0C RID: 12044
		// (get) Token: 0x0600A681 RID: 42625 RVA: 0x001C03CB File Offset: 0x001BE5CB
		// (set) Token: 0x0600A682 RID: 42626 RVA: 0x001C03D3 File Offset: 0x001BE5D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OMPEBDAOFIG AHLAKKGPHGD
		{
			get
			{
				return this.aHLAKKGPHGD_;
			}
			set
			{
				this.aHLAKKGPHGD_ = value;
			}
		}

		// Token: 0x0600A683 RID: 42627 RVA: 0x001C03DC File Offset: 0x001BE5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueGambleMazeInfo);
		}

		// Token: 0x0600A684 RID: 42628 RVA: 0x001C03EC File Offset: 0x001BE5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueGambleMazeInfo other)
		{
			return other != null && (other == this || (this.MazeId == other.MazeId && this.MazeEnable == other.MazeEnable && object.Equals(this.BKNGCBIBPFK, other.BKNGCBIBPFK) && object.Equals(this.AHLAKKGPHGD, other.AHLAKKGPHGD) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A685 RID: 42629 RVA: 0x001C0460 File Offset: 0x001BE660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MazeId != 0U)
			{
				num ^= this.MazeId.GetHashCode();
			}
			if (this.MazeEnable)
			{
				num ^= this.MazeEnable.GetHashCode();
			}
			if (this.bKNGCBIBPFK_ != null)
			{
				num ^= this.BKNGCBIBPFK.GetHashCode();
			}
			if (this.aHLAKKGPHGD_ != null)
			{
				num ^= this.AHLAKKGPHGD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A686 RID: 42630 RVA: 0x001C04E4 File Offset: 0x001BE6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A687 RID: 42631 RVA: 0x001C04EC File Offset: 0x001BE6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A688 RID: 42632 RVA: 0x001C04F8 File Offset: 0x001BE6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.bKNGCBIBPFK_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.BKNGCBIBPFK);
			}
			if (this.MazeEnable)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.MazeEnable);
			}
			if (this.aHLAKKGPHGD_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.AHLAKKGPHGD);
			}
			if (this.MazeId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.MazeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A689 RID: 42633 RVA: 0x001C058C File Offset: 0x001BE78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MazeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MazeId);
			}
			if (this.MazeEnable)
			{
				num += 2;
			}
			if (this.bKNGCBIBPFK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BKNGCBIBPFK);
			}
			if (this.aHLAKKGPHGD_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AHLAKKGPHGD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A68A RID: 42634 RVA: 0x001C0608 File Offset: 0x001BE808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueGambleMazeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MazeId != 0U)
			{
				this.MazeId = other.MazeId;
			}
			if (other.MazeEnable)
			{
				this.MazeEnable = other.MazeEnable;
			}
			if (other.bKNGCBIBPFK_ != null)
			{
				if (this.bKNGCBIBPFK_ == null)
				{
					this.BKNGCBIBPFK = new ENHHGAMEKMB();
				}
				this.BKNGCBIBPFK.MergeFrom(other.BKNGCBIBPFK);
			}
			if (other.aHLAKKGPHGD_ != null)
			{
				if (this.aHLAKKGPHGD_ == null)
				{
					this.AHLAKKGPHGD = new OMPEBDAOFIG();
				}
				this.AHLAKKGPHGD.MergeFrom(other.AHLAKKGPHGD);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A68B RID: 42635 RVA: 0x001C06B0 File Offset: 0x001BE8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A68C RID: 42636 RVA: 0x001C06BC File Offset: 0x001BE8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 26U)
					{
						if (this.bKNGCBIBPFK_ == null)
						{
							this.BKNGCBIBPFK = new ENHHGAMEKMB();
						}
						input.ReadMessage(this.BKNGCBIBPFK);
						continue;
					}
					if (num == 72U)
					{
						this.MazeEnable = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						if (this.aHLAKKGPHGD_ == null)
						{
							this.AHLAKKGPHGD = new OMPEBDAOFIG();
						}
						input.ReadMessage(this.AHLAKKGPHGD);
						continue;
					}
					if (num == 112U)
					{
						this.MazeId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004418 RID: 17432
		private static readonly MessageParser<RogueGambleMazeInfo> _parser = new MessageParser<RogueGambleMazeInfo>(() => new RogueGambleMazeInfo());

		// Token: 0x04004419 RID: 17433
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400441A RID: 17434
		public const int MazeIdFieldNumber = 14;

		// Token: 0x0400441B RID: 17435
		private uint mazeId_;

		// Token: 0x0400441C RID: 17436
		public const int MazeEnableFieldNumber = 9;

		// Token: 0x0400441D RID: 17437
		private bool mazeEnable_;

		// Token: 0x0400441E RID: 17438
		public const int BKNGCBIBPFKFieldNumber = 3;

		// Token: 0x0400441F RID: 17439
		private ENHHGAMEKMB bKNGCBIBPFK_;

		// Token: 0x04004420 RID: 17440
		public const int AHLAKKGPHGDFieldNumber = 13;

		// Token: 0x04004421 RID: 17441
		private OMPEBDAOFIG aHLAKKGPHGD_;
	}
}
