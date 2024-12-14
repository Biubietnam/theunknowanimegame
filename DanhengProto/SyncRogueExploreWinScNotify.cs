using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200128D RID: 4749
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncRogueExploreWinScNotify : IMessage<SyncRogueExploreWinScNotify>, IMessage, IEquatable<SyncRogueExploreWinScNotify>, IDeepCloneable<SyncRogueExploreWinScNotify>, IBufferMessage
	{
		// Token: 0x17003B9C RID: 15260
		// (get) Token: 0x0600D3DF RID: 54239 RVA: 0x00235C84 File Offset: 0x00233E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncRogueExploreWinScNotify> Parser
		{
			get
			{
				return SyncRogueExploreWinScNotify._parser;
			}
		}

		// Token: 0x17003B9D RID: 15261
		// (get) Token: 0x0600D3E0 RID: 54240 RVA: 0x00235C8B File Offset: 0x00233E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncRogueExploreWinScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B9E RID: 15262
		// (get) Token: 0x0600D3E1 RID: 54241 RVA: 0x00235C9D File Offset: 0x00233E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncRogueExploreWinScNotify.Descriptor;
			}
		}

		// Token: 0x0600D3E2 RID: 54242 RVA: 0x00235CA4 File Offset: 0x00233EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueExploreWinScNotify()
		{
		}

		// Token: 0x0600D3E3 RID: 54243 RVA: 0x00235CAC File Offset: 0x00233EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueExploreWinScNotify(SyncRogueExploreWinScNotify other) : this()
		{
			this.isExploreWin_ = other.isExploreWin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D3E4 RID: 54244 RVA: 0x00235CD1 File Offset: 0x00233ED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueExploreWinScNotify Clone()
		{
			return new SyncRogueExploreWinScNotify(this);
		}

		// Token: 0x17003B9F RID: 15263
		// (get) Token: 0x0600D3E5 RID: 54245 RVA: 0x00235CD9 File Offset: 0x00233ED9
		// (set) Token: 0x0600D3E6 RID: 54246 RVA: 0x00235CE1 File Offset: 0x00233EE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsExploreWin
		{
			get
			{
				return this.isExploreWin_;
			}
			set
			{
				this.isExploreWin_ = value;
			}
		}

		// Token: 0x0600D3E7 RID: 54247 RVA: 0x00235CEA File Offset: 0x00233EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncRogueExploreWinScNotify);
		}

		// Token: 0x0600D3E8 RID: 54248 RVA: 0x00235CF8 File Offset: 0x00233EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncRogueExploreWinScNotify other)
		{
			return other != null && (other == this || (this.IsExploreWin == other.IsExploreWin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D3E9 RID: 54249 RVA: 0x00235D28 File Offset: 0x00233F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsExploreWin)
			{
				num ^= this.IsExploreWin.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D3EA RID: 54250 RVA: 0x00235D67 File Offset: 0x00233F67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D3EB RID: 54251 RVA: 0x00235D6F File Offset: 0x00233F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D3EC RID: 54252 RVA: 0x00235D78 File Offset: 0x00233F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsExploreWin)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsExploreWin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D3ED RID: 54253 RVA: 0x00235DAC File Offset: 0x00233FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsExploreWin)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D3EE RID: 54254 RVA: 0x00235DDE File Offset: 0x00233FDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncRogueExploreWinScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsExploreWin)
			{
				this.IsExploreWin = other.IsExploreWin;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D3EF RID: 54255 RVA: 0x00235E0F File Offset: 0x0023400F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D3F0 RID: 54256 RVA: 0x00235E18 File Offset: 0x00234018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IsExploreWin = input.ReadBool();
				}
			}
		}

		// Token: 0x040054CD RID: 21709
		private static readonly MessageParser<SyncRogueExploreWinScNotify> _parser = new MessageParser<SyncRogueExploreWinScNotify>(() => new SyncRogueExploreWinScNotify());

		// Token: 0x040054CE RID: 21710
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054CF RID: 21711
		public const int IsExploreWinFieldNumber = 11;

		// Token: 0x040054D0 RID: 21712
		private bool isExploreWin_;
	}
}
