using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000461 RID: 1121
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterSceneCsReq : IMessage<EnterSceneCsReq>, IMessage, IEquatable<EnterSceneCsReq>, IDeepCloneable<EnterSceneCsReq>, IBufferMessage
	{
		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x060031F3 RID: 12787 RVA: 0x0008983B File Offset: 0x00087A3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterSceneCsReq> Parser
		{
			get
			{
				return EnterSceneCsReq._parser;
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x060031F4 RID: 12788 RVA: 0x00089842 File Offset: 0x00087A42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterSceneCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x060031F5 RID: 12789 RVA: 0x00089854 File Offset: 0x00087A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterSceneCsReq.Descriptor;
			}
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x0008985B File Offset: 0x00087A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSceneCsReq()
		{
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x00089864 File Offset: 0x00087A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSceneCsReq(EnterSceneCsReq other) : this()
		{
			this.gameStoryLineId_ = other.gameStoryLineId_;
			this.isCloseMap_ = other.isCloseMap_;
			this.teleportId_ = other.teleportId_;
			this.entryId_ = other.entryId_;
			this.contentId_ = other.contentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x000898C4 File Offset: 0x00087AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSceneCsReq Clone()
		{
			return new EnterSceneCsReq(this);
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x060031F9 RID: 12793 RVA: 0x000898CC File Offset: 0x00087ACC
		// (set) Token: 0x060031FA RID: 12794 RVA: 0x000898D4 File Offset: 0x00087AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GameStoryLineId
		{
			get
			{
				return this.gameStoryLineId_;
			}
			set
			{
				this.gameStoryLineId_ = value;
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x060031FB RID: 12795 RVA: 0x000898DD File Offset: 0x00087ADD
		// (set) Token: 0x060031FC RID: 12796 RVA: 0x000898E5 File Offset: 0x00087AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCloseMap
		{
			get
			{
				return this.isCloseMap_;
			}
			set
			{
				this.isCloseMap_ = value;
			}
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x060031FD RID: 12797 RVA: 0x000898EE File Offset: 0x00087AEE
		// (set) Token: 0x060031FE RID: 12798 RVA: 0x000898F6 File Offset: 0x00087AF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TeleportId
		{
			get
			{
				return this.teleportId_;
			}
			set
			{
				this.teleportId_ = value;
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x060031FF RID: 12799 RVA: 0x000898FF File Offset: 0x00087AFF
		// (set) Token: 0x06003200 RID: 12800 RVA: 0x00089907 File Offset: 0x00087B07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EntryId
		{
			get
			{
				return this.entryId_;
			}
			set
			{
				this.entryId_ = value;
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06003201 RID: 12801 RVA: 0x00089910 File Offset: 0x00087B10
		// (set) Token: 0x06003202 RID: 12802 RVA: 0x00089918 File Offset: 0x00087B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ContentId
		{
			get
			{
				return this.contentId_;
			}
			set
			{
				this.contentId_ = value;
			}
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x00089921 File Offset: 0x00087B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterSceneCsReq);
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x00089930 File Offset: 0x00087B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterSceneCsReq other)
		{
			return other != null && (other == this || (this.GameStoryLineId == other.GameStoryLineId && this.IsCloseMap == other.IsCloseMap && this.TeleportId == other.TeleportId && this.EntryId == other.EntryId && this.ContentId == other.ContentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x000899AC File Offset: 0x00087BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GameStoryLineId != 0U)
			{
				num ^= this.GameStoryLineId.GetHashCode();
			}
			if (this.IsCloseMap)
			{
				num ^= this.IsCloseMap.GetHashCode();
			}
			if (this.TeleportId != 0U)
			{
				num ^= this.TeleportId.GetHashCode();
			}
			if (this.EntryId != 0U)
			{
				num ^= this.EntryId.GetHashCode();
			}
			if (this.ContentId != 0U)
			{
				num ^= this.ContentId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x00089A4F File Offset: 0x00087C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x00089A57 File Offset: 0x00087C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x00089A60 File Offset: 0x00087C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GameStoryLineId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GameStoryLineId);
			}
			if (this.IsCloseMap)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsCloseMap);
			}
			if (this.ContentId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.ContentId);
			}
			if (this.TeleportId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.TeleportId);
			}
			if (this.EntryId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.EntryId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003209 RID: 12809 RVA: 0x00089B0C File Offset: 0x00087D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GameStoryLineId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameStoryLineId);
			}
			if (this.IsCloseMap)
			{
				num += 2;
			}
			if (this.TeleportId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TeleportId);
			}
			if (this.EntryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntryId);
			}
			if (this.ContentId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ContentId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600320A RID: 12810 RVA: 0x00089BA0 File Offset: 0x00087DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterSceneCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GameStoryLineId != 0U)
			{
				this.GameStoryLineId = other.GameStoryLineId;
			}
			if (other.IsCloseMap)
			{
				this.IsCloseMap = other.IsCloseMap;
			}
			if (other.TeleportId != 0U)
			{
				this.TeleportId = other.TeleportId;
			}
			if (other.EntryId != 0U)
			{
				this.EntryId = other.EntryId;
			}
			if (other.ContentId != 0U)
			{
				this.ContentId = other.ContentId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600320B RID: 12811 RVA: 0x00089C2C File Offset: 0x00087E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600320C RID: 12812 RVA: 0x00089C38 File Offset: 0x00087E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.GameStoryLineId = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IsCloseMap = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ContentId = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.TeleportId = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.EntryId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040013E2 RID: 5090
		private static readonly MessageParser<EnterSceneCsReq> _parser = new MessageParser<EnterSceneCsReq>(() => new EnterSceneCsReq());

		// Token: 0x040013E3 RID: 5091
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013E4 RID: 5092
		public const int GameStoryLineIdFieldNumber = 1;

		// Token: 0x040013E5 RID: 5093
		private uint gameStoryLineId_;

		// Token: 0x040013E6 RID: 5094
		public const int IsCloseMapFieldNumber = 2;

		// Token: 0x040013E7 RID: 5095
		private bool isCloseMap_;

		// Token: 0x040013E8 RID: 5096
		public const int TeleportIdFieldNumber = 13;

		// Token: 0x040013E9 RID: 5097
		private uint teleportId_;

		// Token: 0x040013EA RID: 5098
		public const int EntryIdFieldNumber = 14;

		// Token: 0x040013EB RID: 5099
		private uint entryId_;

		// Token: 0x040013EC RID: 5100
		public const int ContentIdFieldNumber = 10;

		// Token: 0x040013ED RID: 5101
		private uint contentId_;
	}
}
