using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007D9 RID: 2009
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRollShopInfoCsReq : IMessage<GetRollShopInfoCsReq>, IMessage, IEquatable<GetRollShopInfoCsReq>, IDeepCloneable<GetRollShopInfoCsReq>, IBufferMessage
	{
		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x06005999 RID: 22937 RVA: 0x000EF0DC File Offset: 0x000ED2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRollShopInfoCsReq> Parser
		{
			get
			{
				return GetRollShopInfoCsReq._parser;
			}
		}

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x0600599A RID: 22938 RVA: 0x000EF0E3 File Offset: 0x000ED2E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRollShopInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x0600599B RID: 22939 RVA: 0x000EF0F5 File Offset: 0x000ED2F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRollShopInfoCsReq.Descriptor;
			}
		}

		// Token: 0x0600599C RID: 22940 RVA: 0x000EF0FC File Offset: 0x000ED2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRollShopInfoCsReq()
		{
		}

		// Token: 0x0600599D RID: 22941 RVA: 0x000EF104 File Offset: 0x000ED304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRollShopInfoCsReq(GetRollShopInfoCsReq other) : this()
		{
			this.rollShopId_ = other.rollShopId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600599E RID: 22942 RVA: 0x000EF129 File Offset: 0x000ED329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRollShopInfoCsReq Clone()
		{
			return new GetRollShopInfoCsReq(this);
		}

		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x0600599F RID: 22943 RVA: 0x000EF131 File Offset: 0x000ED331
		// (set) Token: 0x060059A0 RID: 22944 RVA: 0x000EF139 File Offset: 0x000ED339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RollShopId
		{
			get
			{
				return this.rollShopId_;
			}
			set
			{
				this.rollShopId_ = value;
			}
		}

		// Token: 0x060059A1 RID: 22945 RVA: 0x000EF142 File Offset: 0x000ED342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRollShopInfoCsReq);
		}

		// Token: 0x060059A2 RID: 22946 RVA: 0x000EF150 File Offset: 0x000ED350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRollShopInfoCsReq other)
		{
			return other != null && (other == this || (this.RollShopId == other.RollShopId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060059A3 RID: 22947 RVA: 0x000EF180 File Offset: 0x000ED380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RollShopId != 0U)
			{
				num ^= this.RollShopId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060059A4 RID: 22948 RVA: 0x000EF1BF File Offset: 0x000ED3BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060059A5 RID: 22949 RVA: 0x000EF1C7 File Offset: 0x000ED3C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060059A6 RID: 22950 RVA: 0x000EF1D0 File Offset: 0x000ED3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RollShopId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.RollShopId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060059A7 RID: 22951 RVA: 0x000EF204 File Offset: 0x000ED404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RollShopId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RollShopId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060059A8 RID: 22952 RVA: 0x000EF242 File Offset: 0x000ED442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRollShopInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RollShopId != 0U)
			{
				this.RollShopId = other.RollShopId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060059A9 RID: 22953 RVA: 0x000EF273 File Offset: 0x000ED473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060059AA RID: 22954 RVA: 0x000EF27C File Offset: 0x000ED47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RollShopId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040022CD RID: 8909
		private static readonly MessageParser<GetRollShopInfoCsReq> _parser = new MessageParser<GetRollShopInfoCsReq>(() => new GetRollShopInfoCsReq());

		// Token: 0x040022CE RID: 8910
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022CF RID: 8911
		public const int RollShopIdFieldNumber = 6;

		// Token: 0x040022D0 RID: 8912
		private uint rollShopId_;
	}
}
