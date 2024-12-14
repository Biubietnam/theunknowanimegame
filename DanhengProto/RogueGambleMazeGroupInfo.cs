using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E8D RID: 3725
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueGambleMazeGroupInfo : IMessage<RogueGambleMazeGroupInfo>, IMessage, IEquatable<RogueGambleMazeGroupInfo>, IDeepCloneable<RogueGambleMazeGroupInfo>, IBufferMessage
	{
		// Token: 0x17002EFF RID: 12031
		// (get) Token: 0x0600A65D RID: 42589 RVA: 0x001BFEC7 File Offset: 0x001BE0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueGambleMazeGroupInfo> Parser
		{
			get
			{
				return RogueGambleMazeGroupInfo._parser;
			}
		}

		// Token: 0x17002F00 RID: 12032
		// (get) Token: 0x0600A65E RID: 42590 RVA: 0x001BFECE File Offset: 0x001BE0CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueGambleMazeGroupInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F01 RID: 12033
		// (get) Token: 0x0600A65F RID: 42591 RVA: 0x001BFEE0 File Offset: 0x001BE0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueGambleMazeGroupInfo.Descriptor;
			}
		}

		// Token: 0x0600A660 RID: 42592 RVA: 0x001BFEE7 File Offset: 0x001BE0E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGambleMazeGroupInfo()
		{
		}

		// Token: 0x0600A661 RID: 42593 RVA: 0x001BFEFC File Offset: 0x001BE0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGambleMazeGroupInfo(RogueGambleMazeGroupInfo other) : this()
		{
			this.groupId_ = other.groupId_;
			this.groupEnable_ = other.groupEnable_;
			this.mazeList_ = other.mazeList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A662 RID: 42594 RVA: 0x001BFF49 File Offset: 0x001BE149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGambleMazeGroupInfo Clone()
		{
			return new RogueGambleMazeGroupInfo(this);
		}

		// Token: 0x17002F02 RID: 12034
		// (get) Token: 0x0600A663 RID: 42595 RVA: 0x001BFF51 File Offset: 0x001BE151
		// (set) Token: 0x0600A664 RID: 42596 RVA: 0x001BFF59 File Offset: 0x001BE159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x17002F03 RID: 12035
		// (get) Token: 0x0600A665 RID: 42597 RVA: 0x001BFF62 File Offset: 0x001BE162
		// (set) Token: 0x0600A666 RID: 42598 RVA: 0x001BFF6A File Offset: 0x001BE16A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GroupEnable
		{
			get
			{
				return this.groupEnable_;
			}
			set
			{
				this.groupEnable_ = value;
			}
		}

		// Token: 0x17002F04 RID: 12036
		// (get) Token: 0x0600A667 RID: 42599 RVA: 0x001BFF73 File Offset: 0x001BE173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueGambleMazeInfo> MazeList
		{
			get
			{
				return this.mazeList_;
			}
		}

		// Token: 0x0600A668 RID: 42600 RVA: 0x001BFF7B File Offset: 0x001BE17B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueGambleMazeGroupInfo);
		}

		// Token: 0x0600A669 RID: 42601 RVA: 0x001BFF8C File Offset: 0x001BE18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueGambleMazeGroupInfo other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.GroupEnable == other.GroupEnable && this.mazeList_.Equals(other.mazeList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A66A RID: 42602 RVA: 0x001BFFEC File Offset: 0x001BE1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.GroupEnable)
			{
				num ^= this.GroupEnable.GetHashCode();
			}
			num ^= this.mazeList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A66B RID: 42603 RVA: 0x001C0052 File Offset: 0x001BE252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A66C RID: 42604 RVA: 0x001C005A File Offset: 0x001BE25A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A66D RID: 42605 RVA: 0x001C0064 File Offset: 0x001BE264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GroupId);
			}
			this.mazeList_.WriteTo(ref output, RogueGambleMazeGroupInfo._repeated_mazeList_codec);
			if (this.GroupEnable)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.GroupEnable);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A66E RID: 42606 RVA: 0x001C00D0 File Offset: 0x001BE2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.GroupEnable)
			{
				num += 2;
			}
			num += this.mazeList_.CalculateSize(RogueGambleMazeGroupInfo._repeated_mazeList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A66F RID: 42607 RVA: 0x001C0130 File Offset: 0x001BE330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueGambleMazeGroupInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.GroupEnable)
			{
				this.GroupEnable = other.GroupEnable;
			}
			this.mazeList_.Add(other.mazeList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A670 RID: 42608 RVA: 0x001C0191 File Offset: 0x001BE391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A671 RID: 42609 RVA: 0x001C019C File Offset: 0x001BE39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 82U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GroupEnable = input.ReadBool();
						}
					}
					else
					{
						this.mazeList_.AddEntriesFrom(ref input, RogueGambleMazeGroupInfo._repeated_mazeList_codec);
					}
				}
				else
				{
					this.GroupId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400440E RID: 17422
		private static readonly MessageParser<RogueGambleMazeGroupInfo> _parser = new MessageParser<RogueGambleMazeGroupInfo>(() => new RogueGambleMazeGroupInfo());

		// Token: 0x0400440F RID: 17423
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004410 RID: 17424
		public const int GroupIdFieldNumber = 1;

		// Token: 0x04004411 RID: 17425
		private uint groupId_;

		// Token: 0x04004412 RID: 17426
		public const int GroupEnableFieldNumber = 13;

		// Token: 0x04004413 RID: 17427
		private bool groupEnable_;

		// Token: 0x04004414 RID: 17428
		public const int MazeListFieldNumber = 10;

		// Token: 0x04004415 RID: 17429
		private static readonly FieldCodec<RogueGambleMazeInfo> _repeated_mazeList_codec = FieldCodec.ForMessage<RogueGambleMazeInfo>(82U, RogueGambleMazeInfo.Parser);

		// Token: 0x04004416 RID: 17430
		private readonly RepeatedField<RogueGambleMazeInfo> mazeList_ = new RepeatedField<RogueGambleMazeInfo>();
	}
}
