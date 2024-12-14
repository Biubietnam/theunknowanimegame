using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FD5 RID: 4053
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournGetSettleInfoCsReq : IMessage<RogueTournGetSettleInfoCsReq>, IMessage, IEquatable<RogueTournGetSettleInfoCsReq>, IDeepCloneable<RogueTournGetSettleInfoCsReq>, IBufferMessage
	{
		// Token: 0x170032DF RID: 13023
		// (get) Token: 0x0600B48A RID: 46218 RVA: 0x001E472C File Offset: 0x001E292C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournGetSettleInfoCsReq> Parser
		{
			get
			{
				return RogueTournGetSettleInfoCsReq._parser;
			}
		}

		// Token: 0x170032E0 RID: 13024
		// (get) Token: 0x0600B48B RID: 46219 RVA: 0x001E4733 File Offset: 0x001E2933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournGetSettleInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170032E1 RID: 13025
		// (get) Token: 0x0600B48C RID: 46220 RVA: 0x001E4745 File Offset: 0x001E2945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournGetSettleInfoCsReq.Descriptor;
			}
		}

		// Token: 0x0600B48D RID: 46221 RVA: 0x001E474C File Offset: 0x001E294C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetSettleInfoCsReq()
		{
		}

		// Token: 0x0600B48E RID: 46222 RVA: 0x001E4754 File Offset: 0x001E2954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetSettleInfoCsReq(RogueTournGetSettleInfoCsReq other) : this()
		{
			this.areaId_ = other.areaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B48F RID: 46223 RVA: 0x001E4779 File Offset: 0x001E2979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetSettleInfoCsReq Clone()
		{
			return new RogueTournGetSettleInfoCsReq(this);
		}

		// Token: 0x170032E2 RID: 13026
		// (get) Token: 0x0600B490 RID: 46224 RVA: 0x001E4781 File Offset: 0x001E2981
		// (set) Token: 0x0600B491 RID: 46225 RVA: 0x001E4789 File Offset: 0x001E2989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x0600B492 RID: 46226 RVA: 0x001E4792 File Offset: 0x001E2992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournGetSettleInfoCsReq);
		}

		// Token: 0x0600B493 RID: 46227 RVA: 0x001E47A0 File Offset: 0x001E29A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournGetSettleInfoCsReq other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B494 RID: 46228 RVA: 0x001E47D0 File Offset: 0x001E29D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B495 RID: 46229 RVA: 0x001E480F File Offset: 0x001E2A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B496 RID: 46230 RVA: 0x001E4817 File Offset: 0x001E2A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B497 RID: 46231 RVA: 0x001E4820 File Offset: 0x001E2A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B498 RID: 46232 RVA: 0x001E4854 File Offset: 0x001E2A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B499 RID: 46233 RVA: 0x001E4892 File Offset: 0x001E2A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournGetSettleInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B49A RID: 46234 RVA: 0x001E48C3 File Offset: 0x001E2AC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B49B RID: 46235 RVA: 0x001E48CC File Offset: 0x001E2ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AreaId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400492B RID: 18731
		private static readonly MessageParser<RogueTournGetSettleInfoCsReq> _parser = new MessageParser<RogueTournGetSettleInfoCsReq>(() => new RogueTournGetSettleInfoCsReq());

		// Token: 0x0400492C RID: 18732
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400492D RID: 18733
		public const int AreaIdFieldNumber = 12;

		// Token: 0x0400492E RID: 18734
		private uint areaId_;
	}
}
