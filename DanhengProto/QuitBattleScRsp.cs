using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D49 RID: 3401
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class QuitBattleScRsp : IMessage<QuitBattleScRsp>, IMessage, IEquatable<QuitBattleScRsp>, IDeepCloneable<QuitBattleScRsp>, IBufferMessage
	{
		// Token: 0x17002AE4 RID: 10980
		// (get) Token: 0x060097EF RID: 38895 RVA: 0x00194D7C File Offset: 0x00192F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<QuitBattleScRsp> Parser
		{
			get
			{
				return QuitBattleScRsp._parser;
			}
		}

		// Token: 0x17002AE5 RID: 10981
		// (get) Token: 0x060097F0 RID: 38896 RVA: 0x00194D83 File Offset: 0x00192F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return QuitBattleScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002AE6 RID: 10982
		// (get) Token: 0x060097F1 RID: 38897 RVA: 0x00194D95 File Offset: 0x00192F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return QuitBattleScRsp.Descriptor;
			}
		}

		// Token: 0x060097F2 RID: 38898 RVA: 0x00194D9C File Offset: 0x00192F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitBattleScRsp()
		{
		}

		// Token: 0x060097F3 RID: 38899 RVA: 0x00194DA4 File Offset: 0x00192FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitBattleScRsp(QuitBattleScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060097F4 RID: 38900 RVA: 0x00194DC9 File Offset: 0x00192FC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public QuitBattleScRsp Clone()
		{
			return new QuitBattleScRsp(this);
		}

		// Token: 0x17002AE7 RID: 10983
		// (get) Token: 0x060097F5 RID: 38901 RVA: 0x00194DD1 File Offset: 0x00192FD1
		// (set) Token: 0x060097F6 RID: 38902 RVA: 0x00194DD9 File Offset: 0x00192FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x060097F7 RID: 38903 RVA: 0x00194DE2 File Offset: 0x00192FE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as QuitBattleScRsp);
		}

		// Token: 0x060097F8 RID: 38904 RVA: 0x00194DF0 File Offset: 0x00192FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(QuitBattleScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060097F9 RID: 38905 RVA: 0x00194E20 File Offset: 0x00193020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060097FA RID: 38906 RVA: 0x00194E5F File Offset: 0x0019305F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060097FB RID: 38907 RVA: 0x00194E67 File Offset: 0x00193067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060097FC RID: 38908 RVA: 0x00194E70 File Offset: 0x00193070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060097FD RID: 38909 RVA: 0x00194EA4 File Offset: 0x001930A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060097FE RID: 38910 RVA: 0x00194EE2 File Offset: 0x001930E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(QuitBattleScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060097FF RID: 38911 RVA: 0x00194F13 File Offset: 0x00193113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009800 RID: 38912 RVA: 0x00194F1C File Offset: 0x0019311C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003B14 RID: 15124
		private static readonly MessageParser<QuitBattleScRsp> _parser = new MessageParser<QuitBattleScRsp>(() => new QuitBattleScRsp());

		// Token: 0x04003B15 RID: 15125
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B16 RID: 15126
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04003B17 RID: 15127
		private uint retcode_;
	}
}
