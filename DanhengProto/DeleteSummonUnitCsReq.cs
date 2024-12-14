using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200037D RID: 893
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DeleteSummonUnitCsReq : IMessage<DeleteSummonUnitCsReq>, IMessage, IEquatable<DeleteSummonUnitCsReq>, IDeepCloneable<DeleteSummonUnitCsReq>, IBufferMessage
	{
		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x060027B9 RID: 10169 RVA: 0x0006EC44 File Offset: 0x0006CE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DeleteSummonUnitCsReq> Parser
		{
			get
			{
				return DeleteSummonUnitCsReq._parser;
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x0006EC4B File Offset: 0x0006CE4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DeleteSummonUnitCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x060027BB RID: 10171 RVA: 0x0006EC5D File Offset: 0x0006CE5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeleteSummonUnitCsReq.Descriptor;
			}
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x0006EC64 File Offset: 0x0006CE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteSummonUnitCsReq()
		{
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x0006EC77 File Offset: 0x0006CE77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteSummonUnitCsReq(DeleteSummonUnitCsReq other) : this()
		{
			this.entityIdList_ = other.entityIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x0006ECA1 File Offset: 0x0006CEA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeleteSummonUnitCsReq Clone()
		{
			return new DeleteSummonUnitCsReq(this);
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x060027BF RID: 10175 RVA: 0x0006ECA9 File Offset: 0x0006CEA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> EntityIdList
		{
			get
			{
				return this.entityIdList_;
			}
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x0006ECB1 File Offset: 0x0006CEB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeleteSummonUnitCsReq);
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x0006ECBF File Offset: 0x0006CEBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeleteSummonUnitCsReq other)
		{
			return other != null && (other == this || (this.entityIdList_.Equals(other.entityIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x0006ECF4 File Offset: 0x0006CEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x0006ED28 File Offset: 0x0006CF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x0006ED30 File Offset: 0x0006CF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x0006ED39 File Offset: 0x0006CF39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityIdList_.WriteTo(ref output, DeleteSummonUnitCsReq._repeated_entityIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x0006ED60 File Offset: 0x0006CF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityIdList_.CalculateSize(DeleteSummonUnitCsReq._repeated_entityIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x0006ED99 File Offset: 0x0006CF99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeleteSummonUnitCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.entityIdList_.Add(other.entityIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x0006EDC7 File Offset: 0x0006CFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x0006EDD0 File Offset: 0x0006CFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityIdList_.AddEntriesFrom(ref input, DeleteSummonUnitCsReq._repeated_entityIdList_codec);
				}
			}
		}

		// Token: 0x04001001 RID: 4097
		private static readonly MessageParser<DeleteSummonUnitCsReq> _parser = new MessageParser<DeleteSummonUnitCsReq>(() => new DeleteSummonUnitCsReq());

		// Token: 0x04001002 RID: 4098
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001003 RID: 4099
		public const int EntityIdListFieldNumber = 7;

		// Token: 0x04001004 RID: 4100
		private static readonly FieldCodec<uint> _repeated_entityIdList_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x04001005 RID: 4101
		private readonly RepeatedField<uint> entityIdList_ = new RepeatedField<uint>();
	}
}
