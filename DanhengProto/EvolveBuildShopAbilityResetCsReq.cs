using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004BD RID: 1213
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildShopAbilityResetCsReq : IMessage<EvolveBuildShopAbilityResetCsReq>, IMessage, IEquatable<EvolveBuildShopAbilityResetCsReq>, IDeepCloneable<EvolveBuildShopAbilityResetCsReq>, IBufferMessage
	{
		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06003639 RID: 13881 RVA: 0x00095283 File Offset: 0x00093483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildShopAbilityResetCsReq> Parser
		{
			get
			{
				return EvolveBuildShopAbilityResetCsReq._parser;
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x0600363A RID: 13882 RVA: 0x0009528A File Offset: 0x0009348A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildShopAbilityResetCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x0600363B RID: 13883 RVA: 0x0009529C File Offset: 0x0009349C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildShopAbilityResetCsReq.Descriptor;
			}
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x000952A3 File Offset: 0x000934A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildShopAbilityResetCsReq()
		{
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x000952AB File Offset: 0x000934AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildShopAbilityResetCsReq(EvolveBuildShopAbilityResetCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x000952C4 File Offset: 0x000934C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildShopAbilityResetCsReq Clone()
		{
			return new EvolveBuildShopAbilityResetCsReq(this);
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x000952CC File Offset: 0x000934CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildShopAbilityResetCsReq);
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x000952DA File Offset: 0x000934DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildShopAbilityResetCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x000952F8 File Offset: 0x000934F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x0009531E File Offset: 0x0009351E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x00095326 File Offset: 0x00093526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x0009532F File Offset: 0x0009352F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x00095348 File Offset: 0x00093548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x0009536E File Offset: 0x0009356E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildShopAbilityResetCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x0009538B File Offset: 0x0009358B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x00095394 File Offset: 0x00093594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001594 RID: 5524
		private static readonly MessageParser<EvolveBuildShopAbilityResetCsReq> _parser = new MessageParser<EvolveBuildShopAbilityResetCsReq>(() => new EvolveBuildShopAbilityResetCsReq());

		// Token: 0x04001595 RID: 5525
		private UnknownFieldSet _unknownFields;
	}
}
