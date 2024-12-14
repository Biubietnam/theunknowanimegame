using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200116B RID: 4459
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpaceZooMutateCsReq : IMessage<SpaceZooMutateCsReq>, IMessage, IEquatable<SpaceZooMutateCsReq>, IDeepCloneable<SpaceZooMutateCsReq>, IBufferMessage
	{
		// Token: 0x1700381D RID: 14365
		// (get) Token: 0x0600C6EE RID: 50926 RVA: 0x00215EE4 File Offset: 0x002140E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpaceZooMutateCsReq> Parser
		{
			get
			{
				return SpaceZooMutateCsReq._parser;
			}
		}

		// Token: 0x1700381E RID: 14366
		// (get) Token: 0x0600C6EF RID: 50927 RVA: 0x00215EEB File Offset: 0x002140EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpaceZooMutateCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700381F RID: 14367
		// (get) Token: 0x0600C6F0 RID: 50928 RVA: 0x00215EFD File Offset: 0x002140FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpaceZooMutateCsReq.Descriptor;
			}
		}

		// Token: 0x0600C6F1 RID: 50929 RVA: 0x00215F04 File Offset: 0x00214104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooMutateCsReq()
		{
		}

		// Token: 0x0600C6F2 RID: 50930 RVA: 0x00215F0C File Offset: 0x0021410C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooMutateCsReq(SpaceZooMutateCsReq other) : this()
		{
			this.itemId_ = other.itemId_;
			this.uniqueId_ = other.uniqueId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C6F3 RID: 50931 RVA: 0x00215F3D File Offset: 0x0021413D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooMutateCsReq Clone()
		{
			return new SpaceZooMutateCsReq(this);
		}

		// Token: 0x17003820 RID: 14368
		// (get) Token: 0x0600C6F4 RID: 50932 RVA: 0x00215F45 File Offset: 0x00214145
		// (set) Token: 0x0600C6F5 RID: 50933 RVA: 0x00215F4D File Offset: 0x0021414D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17003821 RID: 14369
		// (get) Token: 0x0600C6F6 RID: 50934 RVA: 0x00215F56 File Offset: 0x00214156
		// (set) Token: 0x0600C6F7 RID: 50935 RVA: 0x00215F5E File Offset: 0x0021415E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint UniqueId
		{
			get
			{
				return this.uniqueId_;
			}
			set
			{
				this.uniqueId_ = value;
			}
		}

		// Token: 0x0600C6F8 RID: 50936 RVA: 0x00215F67 File Offset: 0x00214167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpaceZooMutateCsReq);
		}

		// Token: 0x0600C6F9 RID: 50937 RVA: 0x00215F75 File Offset: 0x00214175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpaceZooMutateCsReq other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.UniqueId == other.UniqueId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C6FA RID: 50938 RVA: 0x00215FB4 File Offset: 0x002141B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.UniqueId != 0U)
			{
				num ^= this.UniqueId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C6FB RID: 50939 RVA: 0x0021600C File Offset: 0x0021420C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C6FC RID: 50940 RVA: 0x00216014 File Offset: 0x00214214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C6FD RID: 50941 RVA: 0x00216020 File Offset: 0x00214220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.ItemId);
			}
			if (this.UniqueId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.UniqueId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C6FE RID: 50942 RVA: 0x0021607C File Offset: 0x0021427C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this.UniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UniqueId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C6FF RID: 50943 RVA: 0x002160D4 File Offset: 0x002142D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpaceZooMutateCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			if (other.UniqueId != 0U)
			{
				this.UniqueId = other.UniqueId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C700 RID: 50944 RVA: 0x00216124 File Offset: 0x00214324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C701 RID: 50945 RVA: 0x00216130 File Offset: 0x00214330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.UniqueId = input.ReadUInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005060 RID: 20576
		private static readonly MessageParser<SpaceZooMutateCsReq> _parser = new MessageParser<SpaceZooMutateCsReq>(() => new SpaceZooMutateCsReq());

		// Token: 0x04005061 RID: 20577
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005062 RID: 20578
		public const int ItemIdFieldNumber = 6;

		// Token: 0x04005063 RID: 20579
		private uint itemId_;

		// Token: 0x04005064 RID: 20580
		public const int UniqueIdFieldNumber = 15;

		// Token: 0x04005065 RID: 20581
		private uint uniqueId_;
	}
}
