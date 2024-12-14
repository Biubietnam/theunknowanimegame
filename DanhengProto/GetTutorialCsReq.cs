using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000839 RID: 2105
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetTutorialCsReq : IMessage<GetTutorialCsReq>, IMessage, IEquatable<GetTutorialCsReq>, IDeepCloneable<GetTutorialCsReq>, IBufferMessage
	{
		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x06005DA9 RID: 23977 RVA: 0x000F866E File Offset: 0x000F686E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetTutorialCsReq> Parser
		{
			get
			{
				return GetTutorialCsReq._parser;
			}
		}

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x06005DAA RID: 23978 RVA: 0x000F8675 File Offset: 0x000F6875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetTutorialCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x06005DAB RID: 23979 RVA: 0x000F8687 File Offset: 0x000F6887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTutorialCsReq.Descriptor;
			}
		}

		// Token: 0x06005DAC RID: 23980 RVA: 0x000F868E File Offset: 0x000F688E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTutorialCsReq()
		{
		}

		// Token: 0x06005DAD RID: 23981 RVA: 0x000F8696 File Offset: 0x000F6896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTutorialCsReq(GetTutorialCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005DAE RID: 23982 RVA: 0x000F86AF File Offset: 0x000F68AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTutorialCsReq Clone()
		{
			return new GetTutorialCsReq(this);
		}

		// Token: 0x06005DAF RID: 23983 RVA: 0x000F86B7 File Offset: 0x000F68B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTutorialCsReq);
		}

		// Token: 0x06005DB0 RID: 23984 RVA: 0x000F86C5 File Offset: 0x000F68C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetTutorialCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005DB1 RID: 23985 RVA: 0x000F86E4 File Offset: 0x000F68E4
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

		// Token: 0x06005DB2 RID: 23986 RVA: 0x000F870A File Offset: 0x000F690A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005DB3 RID: 23987 RVA: 0x000F8712 File Offset: 0x000F6912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005DB4 RID: 23988 RVA: 0x000F871B File Offset: 0x000F691B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005DB5 RID: 23989 RVA: 0x000F8734 File Offset: 0x000F6934
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

		// Token: 0x06005DB6 RID: 23990 RVA: 0x000F875A File Offset: 0x000F695A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetTutorialCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005DB7 RID: 23991 RVA: 0x000F8777 File Offset: 0x000F6977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005DB8 RID: 23992 RVA: 0x000F8780 File Offset: 0x000F6980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002426 RID: 9254
		private static readonly MessageParser<GetTutorialCsReq> _parser = new MessageParser<GetTutorialCsReq>(() => new GetTutorialCsReq());

		// Token: 0x04002427 RID: 9255
		private UnknownFieldSet _unknownFields;
	}
}
