using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ECF RID: 3791
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicFinishInfo : IMessage<RogueMagicFinishInfo>, IMessage, IEquatable<RogueMagicFinishInfo>, IDeepCloneable<RogueMagicFinishInfo>, IBufferMessage
	{
		// Token: 0x17002FD7 RID: 12247
		// (get) Token: 0x0600A96B RID: 43371 RVA: 0x001C83F3 File Offset: 0x001C65F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicFinishInfo> Parser
		{
			get
			{
				return RogueMagicFinishInfo._parser;
			}
		}

		// Token: 0x17002FD8 RID: 12248
		// (get) Token: 0x0600A96C RID: 43372 RVA: 0x001C83FA File Offset: 0x001C65FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicFinishInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002FD9 RID: 12249
		// (get) Token: 0x0600A96D RID: 43373 RVA: 0x001C840C File Offset: 0x001C660C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicFinishInfo.Descriptor;
			}
		}

		// Token: 0x0600A96E RID: 43374 RVA: 0x001C8413 File Offset: 0x001C6613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicFinishInfo()
		{
		}

		// Token: 0x0600A96F RID: 43375 RVA: 0x001C841C File Offset: 0x001C661C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicFinishInfo(RogueMagicFinishInfo other) : this()
		{
			this.lAIOKLJNPFO_ = ((other.lAIOKLJNPFO_ != null) ? other.lAIOKLJNPFO_.Clone() : null);
			this.rogueTournCurInfo_ = ((other.rogueTournCurInfo_ != null) ? other.rogueTournCurInfo_.Clone() : null);
			this.rogueLineupInfo_ = ((other.rogueLineupInfo_ != null) ? other.rogueLineupInfo_.Clone() : null);
			this.oGIONEOOFIN_ = ((other.oGIONEOOFIN_ != null) ? other.oGIONEOOFIN_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A970 RID: 43376 RVA: 0x001C84B0 File Offset: 0x001C66B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicFinishInfo Clone()
		{
			return new RogueMagicFinishInfo(this);
		}

		// Token: 0x17002FDA RID: 12250
		// (get) Token: 0x0600A971 RID: 43377 RVA: 0x001C84B8 File Offset: 0x001C66B8
		// (set) Token: 0x0600A972 RID: 43378 RVA: 0x001C84C0 File Offset: 0x001C66C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public COFOFDFPLBE LAIOKLJNPFO
		{
			get
			{
				return this.lAIOKLJNPFO_;
			}
			set
			{
				this.lAIOKLJNPFO_ = value;
			}
		}

		// Token: 0x17002FDB RID: 12251
		// (get) Token: 0x0600A973 RID: 43379 RVA: 0x001C84C9 File Offset: 0x001C66C9
		// (set) Token: 0x0600A974 RID: 43380 RVA: 0x001C84D1 File Offset: 0x001C66D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicCurInfo RogueTournCurInfo
		{
			get
			{
				return this.rogueTournCurInfo_;
			}
			set
			{
				this.rogueTournCurInfo_ = value;
			}
		}

		// Token: 0x17002FDC RID: 12252
		// (get) Token: 0x0600A975 RID: 43381 RVA: 0x001C84DA File Offset: 0x001C66DA
		// (set) Token: 0x0600A976 RID: 43382 RVA: 0x001C84E2 File Offset: 0x001C66E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupInfo RogueLineupInfo
		{
			get
			{
				return this.rogueLineupInfo_;
			}
			set
			{
				this.rogueLineupInfo_ = value;
			}
		}

		// Token: 0x17002FDD RID: 12253
		// (get) Token: 0x0600A977 RID: 43383 RVA: 0x001C84EB File Offset: 0x001C66EB
		// (set) Token: 0x0600A978 RID: 43384 RVA: 0x001C84F3 File Offset: 0x001C66F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LMPECJMMBHP OGIONEOOFIN
		{
			get
			{
				return this.oGIONEOOFIN_;
			}
			set
			{
				this.oGIONEOOFIN_ = value;
			}
		}

		// Token: 0x0600A979 RID: 43385 RVA: 0x001C84FC File Offset: 0x001C66FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicFinishInfo);
		}

		// Token: 0x0600A97A RID: 43386 RVA: 0x001C850C File Offset: 0x001C670C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicFinishInfo other)
		{
			return other != null && (other == this || (object.Equals(this.LAIOKLJNPFO, other.LAIOKLJNPFO) && object.Equals(this.RogueTournCurInfo, other.RogueTournCurInfo) && object.Equals(this.RogueLineupInfo, other.RogueLineupInfo) && object.Equals(this.OGIONEOOFIN, other.OGIONEOOFIN) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A97B RID: 43387 RVA: 0x001C858C File Offset: 0x001C678C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.lAIOKLJNPFO_ != null)
			{
				num ^= this.LAIOKLJNPFO.GetHashCode();
			}
			if (this.rogueTournCurInfo_ != null)
			{
				num ^= this.RogueTournCurInfo.GetHashCode();
			}
			if (this.rogueLineupInfo_ != null)
			{
				num ^= this.RogueLineupInfo.GetHashCode();
			}
			if (this.oGIONEOOFIN_ != null)
			{
				num ^= this.OGIONEOOFIN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A97C RID: 43388 RVA: 0x001C860A File Offset: 0x001C680A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A97D RID: 43389 RVA: 0x001C8612 File Offset: 0x001C6812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A97E RID: 43390 RVA: 0x001C861C File Offset: 0x001C681C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.oGIONEOOFIN_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.OGIONEOOFIN);
			}
			if (this.lAIOKLJNPFO_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.LAIOKLJNPFO);
			}
			if (this.rogueTournCurInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.RogueTournCurInfo);
			}
			if (this.rogueLineupInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.RogueLineupInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A97F RID: 43391 RVA: 0x001C86B0 File Offset: 0x001C68B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.lAIOKLJNPFO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LAIOKLJNPFO);
			}
			if (this.rogueTournCurInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurInfo);
			}
			if (this.rogueLineupInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueLineupInfo);
			}
			if (this.oGIONEOOFIN_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OGIONEOOFIN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A980 RID: 43392 RVA: 0x001C8738 File Offset: 0x001C6938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicFinishInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.lAIOKLJNPFO_ != null)
			{
				if (this.lAIOKLJNPFO_ == null)
				{
					this.LAIOKLJNPFO = new COFOFDFPLBE();
				}
				this.LAIOKLJNPFO.MergeFrom(other.LAIOKLJNPFO);
			}
			if (other.rogueTournCurInfo_ != null)
			{
				if (this.rogueTournCurInfo_ == null)
				{
					this.RogueTournCurInfo = new RogueMagicCurInfo();
				}
				this.RogueTournCurInfo.MergeFrom(other.RogueTournCurInfo);
			}
			if (other.rogueLineupInfo_ != null)
			{
				if (this.rogueLineupInfo_ == null)
				{
					this.RogueLineupInfo = new LineupInfo();
				}
				this.RogueLineupInfo.MergeFrom(other.RogueLineupInfo);
			}
			if (other.oGIONEOOFIN_ != null)
			{
				if (this.oGIONEOOFIN_ == null)
				{
					this.OGIONEOOFIN = new LMPECJMMBHP();
				}
				this.OGIONEOOFIN.MergeFrom(other.OGIONEOOFIN);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A981 RID: 43393 RVA: 0x001C8810 File Offset: 0x001C6A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A982 RID: 43394 RVA: 0x001C881C File Offset: 0x001C6A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 74U)
				{
					if (num == 10U)
					{
						if (this.oGIONEOOFIN_ == null)
						{
							this.OGIONEOOFIN = new LMPECJMMBHP();
						}
						input.ReadMessage(this.OGIONEOOFIN);
						continue;
					}
					if (num == 74U)
					{
						if (this.lAIOKLJNPFO_ == null)
						{
							this.LAIOKLJNPFO = new COFOFDFPLBE();
						}
						input.ReadMessage(this.LAIOKLJNPFO);
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						if (this.rogueTournCurInfo_ == null)
						{
							this.RogueTournCurInfo = new RogueMagicCurInfo();
						}
						input.ReadMessage(this.RogueTournCurInfo);
						continue;
					}
					if (num == 122U)
					{
						if (this.rogueLineupInfo_ == null)
						{
							this.RogueLineupInfo = new LineupInfo();
						}
						input.ReadMessage(this.RogueLineupInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004526 RID: 17702
		private static readonly MessageParser<RogueMagicFinishInfo> _parser = new MessageParser<RogueMagicFinishInfo>(() => new RogueMagicFinishInfo());

		// Token: 0x04004527 RID: 17703
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004528 RID: 17704
		public const int LAIOKLJNPFOFieldNumber = 9;

		// Token: 0x04004529 RID: 17705
		private COFOFDFPLBE lAIOKLJNPFO_;

		// Token: 0x0400452A RID: 17706
		public const int RogueTournCurInfoFieldNumber = 13;

		// Token: 0x0400452B RID: 17707
		private RogueMagicCurInfo rogueTournCurInfo_;

		// Token: 0x0400452C RID: 17708
		public const int RogueLineupInfoFieldNumber = 15;

		// Token: 0x0400452D RID: 17709
		private LineupInfo rogueLineupInfo_;

		// Token: 0x0400452E RID: 17710
		public const int OGIONEOOFINFieldNumber = 1;

		// Token: 0x0400452F RID: 17711
		private LMPECJMMBHP oGIONEOOFIN_;
	}
}
