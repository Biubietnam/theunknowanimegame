using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001195 RID: 4501
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartAetherDivideStageBattleCsReq : IMessage<StartAetherDivideStageBattleCsReq>, IMessage, IEquatable<StartAetherDivideStageBattleCsReq>, IDeepCloneable<StartAetherDivideStageBattleCsReq>, IBufferMessage
	{
		// Token: 0x170038AC RID: 14508
		// (get) Token: 0x0600C8EE RID: 51438 RVA: 0x0021B1C9 File Offset: 0x002193C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartAetherDivideStageBattleCsReq> Parser
		{
			get
			{
				return StartAetherDivideStageBattleCsReq._parser;
			}
		}

		// Token: 0x170038AD RID: 14509
		// (get) Token: 0x0600C8EF RID: 51439 RVA: 0x0021B1D0 File Offset: 0x002193D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartAetherDivideStageBattleCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170038AE RID: 14510
		// (get) Token: 0x0600C8F0 RID: 51440 RVA: 0x0021B1E2 File Offset: 0x002193E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartAetherDivideStageBattleCsReq.Descriptor;
			}
		}

		// Token: 0x0600C8F1 RID: 51441 RVA: 0x0021B1E9 File Offset: 0x002193E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAetherDivideStageBattleCsReq()
		{
		}

		// Token: 0x0600C8F2 RID: 51442 RVA: 0x0021B1F1 File Offset: 0x002193F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAetherDivideStageBattleCsReq(StartAetherDivideStageBattleCsReq other) : this()
		{
			this.eventId_ = other.eventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C8F3 RID: 51443 RVA: 0x0021B216 File Offset: 0x00219416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAetherDivideStageBattleCsReq Clone()
		{
			return new StartAetherDivideStageBattleCsReq(this);
		}

		// Token: 0x170038AF RID: 14511
		// (get) Token: 0x0600C8F4 RID: 51444 RVA: 0x0021B21E File Offset: 0x0021941E
		// (set) Token: 0x0600C8F5 RID: 51445 RVA: 0x0021B226 File Offset: 0x00219426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x0600C8F6 RID: 51446 RVA: 0x0021B22F File Offset: 0x0021942F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartAetherDivideStageBattleCsReq);
		}

		// Token: 0x0600C8F7 RID: 51447 RVA: 0x0021B23D File Offset: 0x0021943D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartAetherDivideStageBattleCsReq other)
		{
			return other != null && (other == this || (this.EventId == other.EventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C8F8 RID: 51448 RVA: 0x0021B26C File Offset: 0x0021946C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C8F9 RID: 51449 RVA: 0x0021B2AB File Offset: 0x002194AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C8FA RID: 51450 RVA: 0x0021B2B3 File Offset: 0x002194B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C8FB RID: 51451 RVA: 0x0021B2BC File Offset: 0x002194BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.EventId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C8FC RID: 51452 RVA: 0x0021B2F0 File Offset: 0x002194F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C8FD RID: 51453 RVA: 0x0021B32E File Offset: 0x0021952E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartAetherDivideStageBattleCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C8FE RID: 51454 RVA: 0x0021B35F File Offset: 0x0021955F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C8FF RID: 51455 RVA: 0x0021B368 File Offset: 0x00219568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EventId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400511A RID: 20762
		private static readonly MessageParser<StartAetherDivideStageBattleCsReq> _parser = new MessageParser<StartAetherDivideStageBattleCsReq>(() => new StartAetherDivideStageBattleCsReq());

		// Token: 0x0400511B RID: 20763
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400511C RID: 20764
		public const int EventIdFieldNumber = 13;

		// Token: 0x0400511D RID: 20765
		private uint eventId_;
	}
}
