using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013F9 RID: 5113
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateServerPrefsDataCsReq : IMessage<UpdateServerPrefsDataCsReq>, IMessage, IEquatable<UpdateServerPrefsDataCsReq>, IDeepCloneable<UpdateServerPrefsDataCsReq>, IBufferMessage
	{
		// Token: 0x17004002 RID: 16386
		// (get) Token: 0x0600E3F9 RID: 58361 RVA: 0x0025E429 File Offset: 0x0025C629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdateServerPrefsDataCsReq> Parser
		{
			get
			{
				return UpdateServerPrefsDataCsReq._parser;
			}
		}

		// Token: 0x17004003 RID: 16387
		// (get) Token: 0x0600E3FA RID: 58362 RVA: 0x0025E430 File Offset: 0x0025C630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdateServerPrefsDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17004004 RID: 16388
		// (get) Token: 0x0600E3FB RID: 58363 RVA: 0x0025E442 File Offset: 0x0025C642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateServerPrefsDataCsReq.Descriptor;
			}
		}

		// Token: 0x0600E3FC RID: 58364 RVA: 0x0025E449 File Offset: 0x0025C649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateServerPrefsDataCsReq()
		{
		}

		// Token: 0x0600E3FD RID: 58365 RVA: 0x0025E451 File Offset: 0x0025C651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateServerPrefsDataCsReq(UpdateServerPrefsDataCsReq other) : this()
		{
			this.serverPrefs_ = ((other.serverPrefs_ != null) ? other.serverPrefs_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E3FE RID: 58366 RVA: 0x0025E486 File Offset: 0x0025C686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateServerPrefsDataCsReq Clone()
		{
			return new UpdateServerPrefsDataCsReq(this);
		}

		// Token: 0x17004005 RID: 16389
		// (get) Token: 0x0600E3FF RID: 58367 RVA: 0x0025E48E File Offset: 0x0025C68E
		// (set) Token: 0x0600E400 RID: 58368 RVA: 0x0025E496 File Offset: 0x0025C696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerPrefs ServerPrefs
		{
			get
			{
				return this.serverPrefs_;
			}
			set
			{
				this.serverPrefs_ = value;
			}
		}

		// Token: 0x0600E401 RID: 58369 RVA: 0x0025E49F File Offset: 0x0025C69F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateServerPrefsDataCsReq);
		}

		// Token: 0x0600E402 RID: 58370 RVA: 0x0025E4AD File Offset: 0x0025C6AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateServerPrefsDataCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.ServerPrefs, other.ServerPrefs) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E403 RID: 58371 RVA: 0x0025E4E0 File Offset: 0x0025C6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.serverPrefs_ != null)
			{
				num ^= this.ServerPrefs.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E404 RID: 58372 RVA: 0x0025E51C File Offset: 0x0025C71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E405 RID: 58373 RVA: 0x0025E524 File Offset: 0x0025C724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E406 RID: 58374 RVA: 0x0025E52D File Offset: 0x0025C72D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.serverPrefs_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.ServerPrefs);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E407 RID: 58375 RVA: 0x0025E560 File Offset: 0x0025C760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.serverPrefs_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ServerPrefs);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E408 RID: 58376 RVA: 0x0025E5A0 File Offset: 0x0025C7A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateServerPrefsDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.serverPrefs_ != null)
			{
				if (this.serverPrefs_ == null)
				{
					this.ServerPrefs = new ServerPrefs();
				}
				this.ServerPrefs.MergeFrom(other.ServerPrefs);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E409 RID: 58377 RVA: 0x0025E5F4 File Offset: 0x0025C7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E40A RID: 58378 RVA: 0x0025E600 File Offset: 0x0025C800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.serverPrefs_ == null)
					{
						this.ServerPrefs = new ServerPrefs();
					}
					input.ReadMessage(this.ServerPrefs);
				}
			}
		}

		// Token: 0x04005A97 RID: 23191
		private static readonly MessageParser<UpdateServerPrefsDataCsReq> _parser = new MessageParser<UpdateServerPrefsDataCsReq>(() => new UpdateServerPrefsDataCsReq());

		// Token: 0x04005A98 RID: 23192
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A99 RID: 23193
		public const int ServerPrefsFieldNumber = 11;

		// Token: 0x04005A9A RID: 23194
		private ServerPrefs serverPrefs_;
	}
}
