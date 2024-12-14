using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000851 RID: 2129
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetWolfBroGameDataCsReq : IMessage<GetWolfBroGameDataCsReq>, IMessage, IEquatable<GetWolfBroGameDataCsReq>, IDeepCloneable<GetWolfBroGameDataCsReq>, IBufferMessage
	{
		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x06005EA7 RID: 24231 RVA: 0x000FA824 File Offset: 0x000F8A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetWolfBroGameDataCsReq> Parser
		{
			get
			{
				return GetWolfBroGameDataCsReq._parser;
			}
		}

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x06005EA8 RID: 24232 RVA: 0x000FA82B File Offset: 0x000F8A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetWolfBroGameDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x06005EA9 RID: 24233 RVA: 0x000FA83D File Offset: 0x000F8A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetWolfBroGameDataCsReq.Descriptor;
			}
		}

		// Token: 0x06005EAA RID: 24234 RVA: 0x000FA844 File Offset: 0x000F8A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetWolfBroGameDataCsReq()
		{
		}

		// Token: 0x06005EAB RID: 24235 RVA: 0x000FA84C File Offset: 0x000F8A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetWolfBroGameDataCsReq(GetWolfBroGameDataCsReq other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005EAC RID: 24236 RVA: 0x000FA871 File Offset: 0x000F8A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetWolfBroGameDataCsReq Clone()
		{
			return new GetWolfBroGameDataCsReq(this);
		}

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x06005EAD RID: 24237 RVA: 0x000FA879 File Offset: 0x000F8A79
		// (set) Token: 0x06005EAE RID: 24238 RVA: 0x000FA881 File Offset: 0x000F8A81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06005EAF RID: 24239 RVA: 0x000FA88A File Offset: 0x000F8A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetWolfBroGameDataCsReq);
		}

		// Token: 0x06005EB0 RID: 24240 RVA: 0x000FA898 File Offset: 0x000F8A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetWolfBroGameDataCsReq other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005EB1 RID: 24241 RVA: 0x000FA8C8 File Offset: 0x000F8AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005EB2 RID: 24242 RVA: 0x000FA907 File Offset: 0x000F8B07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005EB3 RID: 24243 RVA: 0x000FA90F File Offset: 0x000F8B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005EB4 RID: 24244 RVA: 0x000FA918 File Offset: 0x000F8B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005EB5 RID: 24245 RVA: 0x000FA94C File Offset: 0x000F8B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005EB6 RID: 24246 RVA: 0x000FA98A File Offset: 0x000F8B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetWolfBroGameDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005EB7 RID: 24247 RVA: 0x000FA9BB File Offset: 0x000F8BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005EB8 RID: 24248 RVA: 0x000FA9C4 File Offset: 0x000F8BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002470 RID: 9328
		private static readonly MessageParser<GetWolfBroGameDataCsReq> _parser = new MessageParser<GetWolfBroGameDataCsReq>(() => new GetWolfBroGameDataCsReq());

		// Token: 0x04002471 RID: 9329
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002472 RID: 9330
		public const int IdFieldNumber = 3;

		// Token: 0x04002473 RID: 9331
		private uint id_;
	}
}
