using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D47 RID: 3399
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuitBattleScNotify : IMessage<QuitBattleScNotify>, IMessage, IEquatable<QuitBattleScNotify>, IDeepCloneable<QuitBattleScNotify>, IBufferMessage
	{
		// Token: 0x17002AE0 RID: 10976
		// (get) Token: 0x060097DC RID: 38876 RVA: 0x00194BBA File Offset: 0x00192DBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuitBattleScNotify> Parser
		{
			get
			{
				return QuitBattleScNotify._parser;
			}
		}

		// Token: 0x17002AE1 RID: 10977
		// (get) Token: 0x060097DD RID: 38877 RVA: 0x00194BC1 File Offset: 0x00192DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuitBattleScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002AE2 RID: 10978
		// (get) Token: 0x060097DE RID: 38878 RVA: 0x00194BD3 File Offset: 0x00192DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuitBattleScNotify.Descriptor;
			}
		}

		// Token: 0x060097DF RID: 38879 RVA: 0x00194BDA File Offset: 0x00192DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitBattleScNotify()
		{
		}

		// Token: 0x060097E0 RID: 38880 RVA: 0x00194BE2 File Offset: 0x00192DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitBattleScNotify(QuitBattleScNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060097E1 RID: 38881 RVA: 0x00194BFB File Offset: 0x00192DFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitBattleScNotify Clone()
		{
			return new QuitBattleScNotify(this);
		}

		// Token: 0x060097E2 RID: 38882 RVA: 0x00194C03 File Offset: 0x00192E03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuitBattleScNotify);
		}

		// Token: 0x060097E3 RID: 38883 RVA: 0x00194C11 File Offset: 0x00192E11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuitBattleScNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060097E4 RID: 38884 RVA: 0x00194C30 File Offset: 0x00192E30
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

		// Token: 0x060097E5 RID: 38885 RVA: 0x00194C56 File Offset: 0x00192E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060097E6 RID: 38886 RVA: 0x00194C5E File Offset: 0x00192E5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060097E7 RID: 38887 RVA: 0x00194C67 File Offset: 0x00192E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060097E8 RID: 38888 RVA: 0x00194C80 File Offset: 0x00192E80
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

		// Token: 0x060097E9 RID: 38889 RVA: 0x00194CA6 File Offset: 0x00192EA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuitBattleScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060097EA RID: 38890 RVA: 0x00194CC3 File Offset: 0x00192EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060097EB RID: 38891 RVA: 0x00194CCC File Offset: 0x00192ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003B11 RID: 15121
		private static readonly MessageParser<QuitBattleScNotify> _parser = new MessageParser<QuitBattleScNotify>(() => new QuitBattleScNotify());

		// Token: 0x04003B12 RID: 15122
		private UnknownFieldSet _unknownFields;
	}
}
