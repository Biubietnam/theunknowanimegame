using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200063D RID: 1597
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChallengeGroupStatisticsCsReq : IMessage<GetChallengeGroupStatisticsCsReq>, IMessage, IEquatable<GetChallengeGroupStatisticsCsReq>, IDeepCloneable<GetChallengeGroupStatisticsCsReq>, IBufferMessage
	{
		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x060047A8 RID: 18344 RVA: 0x000C42A8 File Offset: 0x000C24A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChallengeGroupStatisticsCsReq> Parser
		{
			get
			{
				return GetChallengeGroupStatisticsCsReq._parser;
			}
		}

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x060047A9 RID: 18345 RVA: 0x000C42AF File Offset: 0x000C24AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChallengeGroupStatisticsCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x060047AA RID: 18346 RVA: 0x000C42C1 File Offset: 0x000C24C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChallengeGroupStatisticsCsReq.Descriptor;
			}
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x000C42C8 File Offset: 0x000C24C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeGroupStatisticsCsReq()
		{
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x000C42D0 File Offset: 0x000C24D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeGroupStatisticsCsReq(GetChallengeGroupStatisticsCsReq other) : this()
		{
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060047AD RID: 18349 RVA: 0x000C42F5 File Offset: 0x000C24F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChallengeGroupStatisticsCsReq Clone()
		{
			return new GetChallengeGroupStatisticsCsReq(this);
		}

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x060047AE RID: 18350 RVA: 0x000C42FD File Offset: 0x000C24FD
		// (set) Token: 0x060047AF RID: 18351 RVA: 0x000C4305 File Offset: 0x000C2505
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

		// Token: 0x060047B0 RID: 18352 RVA: 0x000C430E File Offset: 0x000C250E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChallengeGroupStatisticsCsReq);
		}

		// Token: 0x060047B1 RID: 18353 RVA: 0x000C431C File Offset: 0x000C251C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChallengeGroupStatisticsCsReq other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060047B2 RID: 18354 RVA: 0x000C434C File Offset: 0x000C254C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060047B3 RID: 18355 RVA: 0x000C438B File Offset: 0x000C258B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060047B4 RID: 18356 RVA: 0x000C4393 File Offset: 0x000C2593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060047B5 RID: 18357 RVA: 0x000C439C File Offset: 0x000C259C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060047B6 RID: 18358 RVA: 0x000C43D0 File Offset: 0x000C25D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060047B7 RID: 18359 RVA: 0x000C440E File Offset: 0x000C260E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChallengeGroupStatisticsCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060047B8 RID: 18360 RVA: 0x000C443F File Offset: 0x000C263F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060047B9 RID: 18361 RVA: 0x000C4448 File Offset: 0x000C2648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GroupId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001CAD RID: 7341
		private static readonly MessageParser<GetChallengeGroupStatisticsCsReq> _parser = new MessageParser<GetChallengeGroupStatisticsCsReq>(() => new GetChallengeGroupStatisticsCsReq());

		// Token: 0x04001CAE RID: 7342
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CAF RID: 7343
		public const int GroupIdFieldNumber = 8;

		// Token: 0x04001CB0 RID: 7344
		private uint groupId_;
	}
}
