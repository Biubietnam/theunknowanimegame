using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000873 RID: 2163
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GOEBPLEJBAK : IMessage<GOEBPLEJBAK>, IMessage, IEquatable<GOEBPLEJBAK>, IDeepCloneable<GOEBPLEJBAK>, IBufferMessage
	{
		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x0600601D RID: 24605 RVA: 0x000FDFF6 File Offset: 0x000FC1F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GOEBPLEJBAK> Parser
		{
			get
			{
				return GOEBPLEJBAK._parser;
			}
		}

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x0600601E RID: 24606 RVA: 0x000FDFFD File Offset: 0x000FC1FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GOEBPLEJBAKReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x0600601F RID: 24607 RVA: 0x000FE00F File Offset: 0x000FC20F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GOEBPLEJBAK.Descriptor;
			}
		}

		// Token: 0x06006020 RID: 24608 RVA: 0x000FE016 File Offset: 0x000FC216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GOEBPLEJBAK()
		{
		}

		// Token: 0x06006021 RID: 24609 RVA: 0x000FE01E File Offset: 0x000FC21E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GOEBPLEJBAK(GOEBPLEJBAK other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006022 RID: 24610 RVA: 0x000FE037 File Offset: 0x000FC237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GOEBPLEJBAK Clone()
		{
			return new GOEBPLEJBAK(this);
		}

		// Token: 0x06006023 RID: 24611 RVA: 0x000FE03F File Offset: 0x000FC23F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GOEBPLEJBAK);
		}

		// Token: 0x06006024 RID: 24612 RVA: 0x000FE04D File Offset: 0x000FC24D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GOEBPLEJBAK other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06006025 RID: 24613 RVA: 0x000FE06C File Offset: 0x000FC26C
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

		// Token: 0x06006026 RID: 24614 RVA: 0x000FE092 File Offset: 0x000FC292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006027 RID: 24615 RVA: 0x000FE09A File Offset: 0x000FC29A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006028 RID: 24616 RVA: 0x000FE0A3 File Offset: 0x000FC2A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006029 RID: 24617 RVA: 0x000FE0BC File Offset: 0x000FC2BC
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

		// Token: 0x0600602A RID: 24618 RVA: 0x000FE0E2 File Offset: 0x000FC2E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GOEBPLEJBAK other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600602B RID: 24619 RVA: 0x000FE0FF File Offset: 0x000FC2FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600602C RID: 24620 RVA: 0x000FE108 File Offset: 0x000FC308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040024ED RID: 9453
		private static readonly MessageParser<GOEBPLEJBAK> _parser = new MessageParser<GOEBPLEJBAK>(() => new GOEBPLEJBAK());

		// Token: 0x040024EE RID: 9454
		private UnknownFieldSet _unknownFields;
	}
}
