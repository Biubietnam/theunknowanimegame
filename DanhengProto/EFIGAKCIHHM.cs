using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003F9 RID: 1017
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EFIGAKCIHHM : IMessage<EFIGAKCIHHM>, IMessage, IEquatable<EFIGAKCIHHM>, IDeepCloneable<EFIGAKCIHHM>, IBufferMessage
	{
		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06002D2C RID: 11564 RVA: 0x0007CF51 File Offset: 0x0007B151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EFIGAKCIHHM> Parser
		{
			get
			{
				return EFIGAKCIHHM._parser;
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06002D2D RID: 11565 RVA: 0x0007CF58 File Offset: 0x0007B158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EFIGAKCIHHMReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06002D2E RID: 11566 RVA: 0x0007CF6A File Offset: 0x0007B16A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EFIGAKCIHHM.Descriptor;
			}
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x0007CF71 File Offset: 0x0007B171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EFIGAKCIHHM()
		{
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x0007CF7C File Offset: 0x0007B17C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EFIGAKCIHHM(EFIGAKCIHHM other) : this()
		{
			this.rogueFinishInfo_ = ((other.rogueFinishInfo_ != null) ? other.rogueFinishInfo_.Clone() : null);
			this.mapId_ = other.mapId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x0007CFC8 File Offset: 0x0007B1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EFIGAKCIHHM Clone()
		{
			return new EFIGAKCIHHM(this);
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06002D32 RID: 11570 RVA: 0x0007CFD0 File Offset: 0x0007B1D0
		// (set) Token: 0x06002D33 RID: 11571 RVA: 0x0007CFD8 File Offset: 0x0007B1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueFinishInfo RogueFinishInfo
		{
			get
			{
				return this.rogueFinishInfo_;
			}
			set
			{
				this.rogueFinishInfo_ = value;
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06002D34 RID: 11572 RVA: 0x0007CFE1 File Offset: 0x0007B1E1
		// (set) Token: 0x06002D35 RID: 11573 RVA: 0x0007CFE9 File Offset: 0x0007B1E9
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

		// Token: 0x06002D36 RID: 11574 RVA: 0x0007CFF2 File Offset: 0x0007B1F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EFIGAKCIHHM);
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x0007D000 File Offset: 0x0007B200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EFIGAKCIHHM other)
		{
			return other != null && (other == this || (object.Equals(this.RogueFinishInfo, other.RogueFinishInfo) && this.MapId == other.MapId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x0007D050 File Offset: 0x0007B250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueFinishInfo_ != null)
			{
				num ^= this.RogueFinishInfo.GetHashCode();
			}
			if (this.MapId != 0U)
			{
				num ^= this.MapId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x0007D0A5 File Offset: 0x0007B2A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x0007D0AD File Offset: 0x0007B2AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x0007D0B8 File Offset: 0x0007B2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueFinishInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RogueFinishInfo);
			}
			if (this.MapId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.MapId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x0007D114 File Offset: 0x0007B314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueFinishInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueFinishInfo);
			}
			if (this.MapId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MapId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x0007D16C File Offset: 0x0007B36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EFIGAKCIHHM other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueFinishInfo_ != null)
			{
				if (this.rogueFinishInfo_ == null)
				{
					this.RogueFinishInfo = new RogueFinishInfo();
				}
				this.RogueFinishInfo.MergeFrom(other.RogueFinishInfo);
			}
			if (other.MapId != 0U)
			{
				this.MapId = other.MapId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002D3E RID: 11582 RVA: 0x0007D1D4 File Offset: 0x0007B3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x0007D1E0 File Offset: 0x0007B3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MapId = input.ReadUInt32();
					}
				}
				else
				{
					if (this.rogueFinishInfo_ == null)
					{
						this.RogueFinishInfo = new RogueFinishInfo();
					}
					input.ReadMessage(this.RogueFinishInfo);
				}
			}
		}

		// Token: 0x04001231 RID: 4657
		private static readonly MessageParser<EFIGAKCIHHM> _parser = new MessageParser<EFIGAKCIHHM>(() => new EFIGAKCIHHM());

		// Token: 0x04001232 RID: 4658
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001233 RID: 4659
		public const int RogueFinishInfoFieldNumber = 3;

		// Token: 0x04001234 RID: 4660
		private RogueFinishInfo rogueFinishInfo_;

		// Token: 0x04001235 RID: 4661
		public const int MapIdFieldNumber = 12;

		// Token: 0x04001236 RID: 4662
		private uint mapId_;
	}
}
