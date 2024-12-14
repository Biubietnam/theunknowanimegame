using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D31 RID: 3377
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PunkLordRaidTimeOutScNotify : IMessage<PunkLordRaidTimeOutScNotify>, IMessage, IEquatable<PunkLordRaidTimeOutScNotify>, IDeepCloneable<PunkLordRaidTimeOutScNotify>, IBufferMessage
	{
		// Token: 0x17002A8B RID: 10891
		// (get) Token: 0x060096D4 RID: 38612 RVA: 0x00191587 File Offset: 0x0018F787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PunkLordRaidTimeOutScNotify> Parser
		{
			get
			{
				return PunkLordRaidTimeOutScNotify._parser;
			}
		}

		// Token: 0x17002A8C RID: 10892
		// (get) Token: 0x060096D5 RID: 38613 RVA: 0x0019158E File Offset: 0x0018F78E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PunkLordRaidTimeOutScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A8D RID: 10893
		// (get) Token: 0x060096D6 RID: 38614 RVA: 0x001915A0 File Offset: 0x0018F7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PunkLordRaidTimeOutScNotify.Descriptor;
			}
		}

		// Token: 0x060096D7 RID: 38615 RVA: 0x001915A7 File Offset: 0x0018F7A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordRaidTimeOutScNotify()
		{
		}

		// Token: 0x060096D8 RID: 38616 RVA: 0x001915AF File Offset: 0x0018F7AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordRaidTimeOutScNotify(PunkLordRaidTimeOutScNotify other) : this()
		{
			this.iOEBEBCENHO_ = ((other.iOEBEBCENHO_ != null) ? other.iOEBEBCENHO_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060096D9 RID: 38617 RVA: 0x001915E4 File Offset: 0x0018F7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordRaidTimeOutScNotify Clone()
		{
			return new PunkLordRaidTimeOutScNotify(this);
		}

		// Token: 0x17002A8E RID: 10894
		// (get) Token: 0x060096DA RID: 38618 RVA: 0x001915EC File Offset: 0x0018F7EC
		// (set) Token: 0x060096DB RID: 38619 RVA: 0x001915F4 File Offset: 0x0018F7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordMonsterBasicInfo IOEBEBCENHO
		{
			get
			{
				return this.iOEBEBCENHO_;
			}
			set
			{
				this.iOEBEBCENHO_ = value;
			}
		}

		// Token: 0x060096DC RID: 38620 RVA: 0x001915FD File Offset: 0x0018F7FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PunkLordRaidTimeOutScNotify);
		}

		// Token: 0x060096DD RID: 38621 RVA: 0x0019160B File Offset: 0x0018F80B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PunkLordRaidTimeOutScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.IOEBEBCENHO, other.IOEBEBCENHO) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060096DE RID: 38622 RVA: 0x00191640 File Offset: 0x0018F840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.iOEBEBCENHO_ != null)
			{
				num ^= this.IOEBEBCENHO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060096DF RID: 38623 RVA: 0x0019167C File Offset: 0x0018F87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060096E0 RID: 38624 RVA: 0x00191684 File Offset: 0x0018F884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060096E1 RID: 38625 RVA: 0x0019168D File Offset: 0x0018F88D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.iOEBEBCENHO_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.IOEBEBCENHO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060096E2 RID: 38626 RVA: 0x001916C0 File Offset: 0x0018F8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.iOEBEBCENHO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IOEBEBCENHO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060096E3 RID: 38627 RVA: 0x00191700 File Offset: 0x0018F900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PunkLordRaidTimeOutScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.iOEBEBCENHO_ != null)
			{
				if (this.iOEBEBCENHO_ == null)
				{
					this.IOEBEBCENHO = new PunkLordMonsterBasicInfo();
				}
				this.IOEBEBCENHO.MergeFrom(other.IOEBEBCENHO);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060096E4 RID: 38628 RVA: 0x00191754 File Offset: 0x0018F954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060096E5 RID: 38629 RVA: 0x00191760 File Offset: 0x0018F960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.iOEBEBCENHO_ == null)
					{
						this.IOEBEBCENHO = new PunkLordMonsterBasicInfo();
					}
					input.ReadMessage(this.IOEBEBCENHO);
				}
			}
		}

		// Token: 0x04003A87 RID: 14983
		private static readonly MessageParser<PunkLordRaidTimeOutScNotify> _parser = new MessageParser<PunkLordRaidTimeOutScNotify>(() => new PunkLordRaidTimeOutScNotify());

		// Token: 0x04003A88 RID: 14984
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A89 RID: 14985
		public const int IOEBEBCENHOFieldNumber = 12;

		// Token: 0x04003A8A RID: 14986
		private PunkLordMonsterBasicInfo iOEBEBCENHO_;
	}
}
