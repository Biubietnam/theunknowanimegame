using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200119D RID: 4509
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartBattleCollegeCsReq : IMessage<StartBattleCollegeCsReq>, IMessage, IEquatable<StartBattleCollegeCsReq>, IDeepCloneable<StartBattleCollegeCsReq>, IBufferMessage
	{
		// Token: 0x170038C2 RID: 14530
		// (get) Token: 0x0600C946 RID: 51526 RVA: 0x0021BD88 File Offset: 0x00219F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartBattleCollegeCsReq> Parser
		{
			get
			{
				return StartBattleCollegeCsReq._parser;
			}
		}

		// Token: 0x170038C3 RID: 14531
		// (get) Token: 0x0600C947 RID: 51527 RVA: 0x0021BD8F File Offset: 0x00219F8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartBattleCollegeCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170038C4 RID: 14532
		// (get) Token: 0x0600C948 RID: 51528 RVA: 0x0021BDA1 File Offset: 0x00219FA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartBattleCollegeCsReq.Descriptor;
			}
		}

		// Token: 0x0600C949 RID: 51529 RVA: 0x0021BDA8 File Offset: 0x00219FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartBattleCollegeCsReq()
		{
		}

		// Token: 0x0600C94A RID: 51530 RVA: 0x0021BDB0 File Offset: 0x00219FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartBattleCollegeCsReq(StartBattleCollegeCsReq other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C94B RID: 51531 RVA: 0x0021BDD5 File Offset: 0x00219FD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartBattleCollegeCsReq Clone()
		{
			return new StartBattleCollegeCsReq(this);
		}

		// Token: 0x170038C5 RID: 14533
		// (get) Token: 0x0600C94C RID: 51532 RVA: 0x0021BDDD File Offset: 0x00219FDD
		// (set) Token: 0x0600C94D RID: 51533 RVA: 0x0021BDE5 File Offset: 0x00219FE5
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

		// Token: 0x0600C94E RID: 51534 RVA: 0x0021BDEE File Offset: 0x00219FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartBattleCollegeCsReq);
		}

		// Token: 0x0600C94F RID: 51535 RVA: 0x0021BDFC File Offset: 0x00219FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartBattleCollegeCsReq other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C950 RID: 51536 RVA: 0x0021BE2C File Offset: 0x0021A02C
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

		// Token: 0x0600C951 RID: 51537 RVA: 0x0021BE6B File Offset: 0x0021A06B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C952 RID: 51538 RVA: 0x0021BE73 File Offset: 0x0021A073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C953 RID: 51539 RVA: 0x0021BE7C File Offset: 0x0021A07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C954 RID: 51540 RVA: 0x0021BEB0 File Offset: 0x0021A0B0
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

		// Token: 0x0600C955 RID: 51541 RVA: 0x0021BEEE File Offset: 0x0021A0EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartBattleCollegeCsReq other)
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

		// Token: 0x0600C956 RID: 51542 RVA: 0x0021BF1F File Offset: 0x0021A11F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C957 RID: 51543 RVA: 0x0021BF28 File Offset: 0x0021A128
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
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005132 RID: 20786
		private static readonly MessageParser<StartBattleCollegeCsReq> _parser = new MessageParser<StartBattleCollegeCsReq>(() => new StartBattleCollegeCsReq());

		// Token: 0x04005133 RID: 20787
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005134 RID: 20788
		public const int IdFieldNumber = 4;

		// Token: 0x04005135 RID: 20789
		private uint id_;
	}
}
