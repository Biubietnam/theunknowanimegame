using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B3D RID: 2877
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGetDailyInitItemCsReq : IMessage<MonopolyGetDailyInitItemCsReq>, IMessage, IEquatable<MonopolyGetDailyInitItemCsReq>, IDeepCloneable<MonopolyGetDailyInitItemCsReq>, IBufferMessage
	{
		// Token: 0x170023B6 RID: 9142
		// (get) Token: 0x06007F57 RID: 32599 RVA: 0x00150764 File Offset: 0x0014E964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGetDailyInitItemCsReq> Parser
		{
			get
			{
				return MonopolyGetDailyInitItemCsReq._parser;
			}
		}

		// Token: 0x170023B7 RID: 9143
		// (get) Token: 0x06007F58 RID: 32600 RVA: 0x0015076B File Offset: 0x0014E96B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGetDailyInitItemCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170023B8 RID: 9144
		// (get) Token: 0x06007F59 RID: 32601 RVA: 0x0015077D File Offset: 0x0014E97D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGetDailyInitItemCsReq.Descriptor;
			}
		}

		// Token: 0x06007F5A RID: 32602 RVA: 0x00150784 File Offset: 0x0014E984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetDailyInitItemCsReq()
		{
		}

		// Token: 0x06007F5B RID: 32603 RVA: 0x0015078C File Offset: 0x0014E98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetDailyInitItemCsReq(MonopolyGetDailyInitItemCsReq other) : this()
		{
			this.iHEANNCJFBI_ = other.iHEANNCJFBI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F5C RID: 32604 RVA: 0x001507B1 File Offset: 0x0014E9B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetDailyInitItemCsReq Clone()
		{
			return new MonopolyGetDailyInitItemCsReq(this);
		}

		// Token: 0x170023B9 RID: 9145
		// (get) Token: 0x06007F5D RID: 32605 RVA: 0x001507B9 File Offset: 0x0014E9B9
		// (set) Token: 0x06007F5E RID: 32606 RVA: 0x001507C1 File Offset: 0x0014E9C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IHEANNCJFBI
		{
			get
			{
				return this.iHEANNCJFBI_;
			}
			set
			{
				this.iHEANNCJFBI_ = value;
			}
		}

		// Token: 0x06007F5F RID: 32607 RVA: 0x001507CA File Offset: 0x0014E9CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGetDailyInitItemCsReq);
		}

		// Token: 0x06007F60 RID: 32608 RVA: 0x001507D8 File Offset: 0x0014E9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGetDailyInitItemCsReq other)
		{
			return other != null && (other == this || (this.IHEANNCJFBI == other.IHEANNCJFBI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007F61 RID: 32609 RVA: 0x00150808 File Offset: 0x0014EA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IHEANNCJFBI)
			{
				num ^= this.IHEANNCJFBI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F62 RID: 32610 RVA: 0x00150847 File Offset: 0x0014EA47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007F63 RID: 32611 RVA: 0x0015084F File Offset: 0x0014EA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F64 RID: 32612 RVA: 0x00150858 File Offset: 0x0014EA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IHEANNCJFBI)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IHEANNCJFBI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F65 RID: 32613 RVA: 0x0015088C File Offset: 0x0014EA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IHEANNCJFBI)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F66 RID: 32614 RVA: 0x001508BE File Offset: 0x0014EABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGetDailyInitItemCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IHEANNCJFBI)
			{
				this.IHEANNCJFBI = other.IHEANNCJFBI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007F67 RID: 32615 RVA: 0x001508EF File Offset: 0x0014EAEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F68 RID: 32616 RVA: 0x001508F8 File Offset: 0x0014EAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IHEANNCJFBI = input.ReadBool();
				}
			}
		}

		// Token: 0x040030C6 RID: 12486
		private static readonly MessageParser<MonopolyGetDailyInitItemCsReq> _parser = new MessageParser<MonopolyGetDailyInitItemCsReq>(() => new MonopolyGetDailyInitItemCsReq());

		// Token: 0x040030C7 RID: 12487
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030C8 RID: 12488
		public const int IHEANNCJFBIFieldNumber = 7;

		// Token: 0x040030C9 RID: 12489
		private bool iHEANNCJFBI_;
	}
}
