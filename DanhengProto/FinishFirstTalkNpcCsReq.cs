using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200057F RID: 1407
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishFirstTalkNpcCsReq : IMessage<FinishFirstTalkNpcCsReq>, IMessage, IEquatable<FinishFirstTalkNpcCsReq>, IDeepCloneable<FinishFirstTalkNpcCsReq>, IBufferMessage
	{
		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x06003EC9 RID: 16073 RVA: 0x000AB95C File Offset: 0x000A9B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishFirstTalkNpcCsReq> Parser
		{
			get
			{
				return FinishFirstTalkNpcCsReq._parser;
			}
		}

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x06003ECA RID: 16074 RVA: 0x000AB963 File Offset: 0x000A9B63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishFirstTalkNpcCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x06003ECB RID: 16075 RVA: 0x000AB975 File Offset: 0x000A9B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishFirstTalkNpcCsReq.Descriptor;
			}
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x000AB97C File Offset: 0x000A9B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishFirstTalkNpcCsReq()
		{
		}

		// Token: 0x06003ECD RID: 16077 RVA: 0x000AB984 File Offset: 0x000A9B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishFirstTalkNpcCsReq(FinishFirstTalkNpcCsReq other) : this()
		{
			this.npcId_ = other.npcId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003ECE RID: 16078 RVA: 0x000AB9A9 File Offset: 0x000A9BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishFirstTalkNpcCsReq Clone()
		{
			return new FinishFirstTalkNpcCsReq(this);
		}

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x06003ECF RID: 16079 RVA: 0x000AB9B1 File Offset: 0x000A9BB1
		// (set) Token: 0x06003ED0 RID: 16080 RVA: 0x000AB9B9 File Offset: 0x000A9BB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NpcId
		{
			get
			{
				return this.npcId_;
			}
			set
			{
				this.npcId_ = value;
			}
		}

		// Token: 0x06003ED1 RID: 16081 RVA: 0x000AB9C2 File Offset: 0x000A9BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishFirstTalkNpcCsReq);
		}

		// Token: 0x06003ED2 RID: 16082 RVA: 0x000AB9D0 File Offset: 0x000A9BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishFirstTalkNpcCsReq other)
		{
			return other != null && (other == this || (this.NpcId == other.NpcId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x000ABA00 File Offset: 0x000A9C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NpcId != 0U)
			{
				num ^= this.NpcId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x000ABA3F File Offset: 0x000A9C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x000ABA47 File Offset: 0x000A9C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x000ABA50 File Offset: 0x000A9C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NpcId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.NpcId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003ED7 RID: 16087 RVA: 0x000ABA84 File Offset: 0x000A9C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NpcId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NpcId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003ED8 RID: 16088 RVA: 0x000ABAC2 File Offset: 0x000A9CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishFirstTalkNpcCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NpcId != 0U)
			{
				this.NpcId = other.NpcId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003ED9 RID: 16089 RVA: 0x000ABAF3 File Offset: 0x000A9CF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003EDA RID: 16090 RVA: 0x000ABAFC File Offset: 0x000A9CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.NpcId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400190A RID: 6410
		private static readonly MessageParser<FinishFirstTalkNpcCsReq> _parser = new MessageParser<FinishFirstTalkNpcCsReq>(() => new FinishFirstTalkNpcCsReq());

		// Token: 0x0400190B RID: 6411
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400190C RID: 6412
		public const int NpcIdFieldNumber = 4;

		// Token: 0x0400190D RID: 6413
		private uint npcId_;
	}
}
