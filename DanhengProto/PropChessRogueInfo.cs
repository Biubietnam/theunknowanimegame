using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D13 RID: 3347
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PropChessRogueInfo : IMessage<PropChessRogueInfo>, IMessage, IEquatable<PropChessRogueInfo>, IDeepCloneable<PropChessRogueInfo>, IBufferMessage
	{
		// Token: 0x17002A21 RID: 10785
		// (get) Token: 0x06009574 RID: 38260 RVA: 0x0018D2B8 File Offset: 0x0018B4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PropChessRogueInfo> Parser
		{
			get
			{
				return PropChessRogueInfo._parser;
			}
		}

		// Token: 0x17002A22 RID: 10786
		// (get) Token: 0x06009575 RID: 38261 RVA: 0x0018D2BF File Offset: 0x0018B4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PropChessRogueInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A23 RID: 10787
		// (get) Token: 0x06009576 RID: 38262 RVA: 0x0018D2D1 File Offset: 0x0018B4D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PropChessRogueInfo.Descriptor;
			}
		}

		// Token: 0x06009577 RID: 38263 RVA: 0x0018D2D8 File Offset: 0x0018B4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropChessRogueInfo()
		{
		}

		// Token: 0x06009578 RID: 38264 RVA: 0x0018D2E0 File Offset: 0x0018B4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropChessRogueInfo(PropChessRogueInfo other) : this()
		{
			this.aOJBLAEOBHA_ = other.aOJBLAEOBHA_;
			this.enterNextCell_ = other.enterNextCell_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009579 RID: 38265 RVA: 0x0018D311 File Offset: 0x0018B511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropChessRogueInfo Clone()
		{
			return new PropChessRogueInfo(this);
		}

		// Token: 0x17002A24 RID: 10788
		// (get) Token: 0x0600957A RID: 38266 RVA: 0x0018D319 File Offset: 0x0018B519
		// (set) Token: 0x0600957B RID: 38267 RVA: 0x0018D321 File Offset: 0x0018B521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AOJBLAEOBHA
		{
			get
			{
				return this.aOJBLAEOBHA_;
			}
			set
			{
				this.aOJBLAEOBHA_ = value;
			}
		}

		// Token: 0x17002A25 RID: 10789
		// (get) Token: 0x0600957C RID: 38268 RVA: 0x0018D32A File Offset: 0x0018B52A
		// (set) Token: 0x0600957D RID: 38269 RVA: 0x0018D332 File Offset: 0x0018B532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EnterNextCell
		{
			get
			{
				return this.enterNextCell_;
			}
			set
			{
				this.enterNextCell_ = value;
			}
		}

		// Token: 0x0600957E RID: 38270 RVA: 0x0018D33B File Offset: 0x0018B53B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PropChessRogueInfo);
		}

		// Token: 0x0600957F RID: 38271 RVA: 0x0018D349 File Offset: 0x0018B549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PropChessRogueInfo other)
		{
			return other != null && (other == this || (this.AOJBLAEOBHA == other.AOJBLAEOBHA && this.EnterNextCell == other.EnterNextCell && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009580 RID: 38272 RVA: 0x0018D388 File Offset: 0x0018B588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AOJBLAEOBHA)
			{
				num ^= this.AOJBLAEOBHA.GetHashCode();
			}
			if (this.EnterNextCell)
			{
				num ^= this.EnterNextCell.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009581 RID: 38273 RVA: 0x0018D3E0 File Offset: 0x0018B5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009582 RID: 38274 RVA: 0x0018D3E8 File Offset: 0x0018B5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009583 RID: 38275 RVA: 0x0018D3F4 File Offset: 0x0018B5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AOJBLAEOBHA)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.AOJBLAEOBHA);
			}
			if (this.EnterNextCell)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.EnterNextCell);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009584 RID: 38276 RVA: 0x0018D450 File Offset: 0x0018B650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AOJBLAEOBHA)
			{
				num += 2;
			}
			if (this.EnterNextCell)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009585 RID: 38277 RVA: 0x0018D490 File Offset: 0x0018B690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PropChessRogueInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AOJBLAEOBHA)
			{
				this.AOJBLAEOBHA = other.AOJBLAEOBHA;
			}
			if (other.EnterNextCell)
			{
				this.EnterNextCell = other.EnterNextCell;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009586 RID: 38278 RVA: 0x0018D4E0 File Offset: 0x0018B6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009587 RID: 38279 RVA: 0x0018D4EC File Offset: 0x0018B6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EnterNextCell = input.ReadBool();
					}
				}
				else
				{
					this.AOJBLAEOBHA = input.ReadBool();
				}
			}
		}

		// Token: 0x040039E9 RID: 14825
		private static readonly MessageParser<PropChessRogueInfo> _parser = new MessageParser<PropChessRogueInfo>(() => new PropChessRogueInfo());

		// Token: 0x040039EA RID: 14826
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039EB RID: 14827
		public const int AOJBLAEOBHAFieldNumber = 2;

		// Token: 0x040039EC RID: 14828
		private bool aOJBLAEOBHA_;

		// Token: 0x040039ED RID: 14829
		public const int EnterNextCellFieldNumber = 11;

		// Token: 0x040039EE RID: 14830
		private bool enterNextCell_;
	}
}
